using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float _explosionRadius = 5;
    [SerializeField] private float _explosionForce = 500;

    private int _height = 2;
    public void UseExplosion()
    {
        Collider[] overlappedColliders = Physics.OverlapSphere(transform.position, _explosionRadius);

        for(int i = 0; i <= overlappedColliders.Length; i++)
        {
            Rigidbody rigidbody = overlappedColliders[i].attachedRigidbody;

            if (rigidbody)
            {
                rigidbody.AddExplosionForce(_explosionForce, transform.position, _explosionRadius, _height);
            }
        }
    }
}