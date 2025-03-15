using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableCard", menuName = "ScriptableCard")]
public class ScriptableCard : ScriptableObject
{
    public int idCard;
    public string nameCard; 
    public string description;
    public Sprite previewImage;
    public GameObject obj3D; 


}
