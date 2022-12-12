using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "CharacterModel", menuName = "objects/CharacterModel")]
public class CharacterModel : ScriptableObject
{
    public GameObject GenderModel;
    public Material ModelMaterial;
    public HairShapes availableHairShapes;
    public HeadShapes avaliableHeadShapes;
    public Mesh helmet;
    public Mesh hair;
    public Mesh head;
    public Mesh upperbody;
    public Mesh gauntlets;
    public Mesh cape;
    public Mesh legs;
    public Mesh boots;
    public GameObject weaponSocket;
    

}