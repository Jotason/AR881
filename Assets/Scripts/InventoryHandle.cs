using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryHandle : MonoBehaviour
{

    public List<ScriptableCard> Cards;

    public GameObject standardCardPrefab;
    public Transform parentCard; 

    void Start()
    {
        foreach (var card in Cards)
        {
            GameObject _tempcard = Instantiate(standardCardPrefab, parentCard);
            _tempcard.GetComponent<StandardCardController>().scriptableCard = card;
            _tempcard.GetComponent<StandardCardController>().LoadData();
        }
        
    }

    void Update()
    {
        
    }
}
