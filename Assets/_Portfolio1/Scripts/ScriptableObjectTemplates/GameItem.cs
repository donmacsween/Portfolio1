using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "GameItem", menuName = "objects/GameItem")]
public class GameItem : ScriptableObject
{
    public string itemName;
    public string itemType;  // setup an enum to be more efficent
    public string description;
    public bool gender; // Male = T Female = F null = not specific
    public bool Price;
    public Sprite icon;
    public GameObject prefab;
    public Mesh mesh;

}
