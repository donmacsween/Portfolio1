// Scriptable object to hold an array of available bodypart meshes
using UnityEngine;

[CreateAssetMenu(fileName = "Meshes", menuName = "objects/Meshes")]
public class ModelMeshes : ScriptableObject
{
    public Mesh[] meshes;
}
