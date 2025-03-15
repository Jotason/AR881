using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StandardCardController : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public Image previewImage;
    public TextMeshProUGUI description;
    [HideInInspector] public ScriptableCard scriptableCard;

    [HideInInspector] public GameObject obj3D;
    public void LoadData() { 
    
        titleText.text = scriptableCard.nameCard;
        previewImage.sprite = scriptableCard.previewImage;
        obj3D = scriptableCard.obj3D;
        description.text = scriptableCard.description;  

    }
}
