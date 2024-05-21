using UnityEngine;

[RequireComponent(typeof(Explosion), typeof(Color))]

public class Separat : MonoBehaviour
{
    private static float _separation = 1;

    private int _reductionFactor = 2;
    private float _chans;

    private void Start()
    {
        gameObject.AddComponent<Color>().Replace();

        _chans = GetSplitChance();
    }

    private void OnMouseDown()
    {
        if (_chans >= Random.value)
        {
            AddNewItem();
            
            SetSplitChance(_chans / _reductionFactor);
            
            Destroy(gameObject);

            gameObject.AddComponent<Explosion>().UseExplosion();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void AddNewItem()
    {
        int minQuantity = 2;
        int maxQuantity = 6;

        int quantityItems = Random.Range(minQuantity, maxQuantity);

        for (int i = 0; i <= quantityItems; i++)
        {
            ReduceSize(ÑreateNewGameObject());
        }
    }

    private GameObject ÑreateNewGameObject()
    {
        return Instantiate(gameObject, transform.position, Random.rotationUniform);
    }

    private void ReduceSize(GameObject newItem)
    {
        int scaleItem = 2;

        newItem.transform.localScale = transform.lossyScale / scaleItem;
    }

    private void SetSplitChance(float value)
    {
        _separation = value;
    }

    private float GetSplitChance()
    {
        return _separation;
    }
}