// // Scriptable object to hold an array of Colors to choose from
using UnityEngine;

[CreateAssetMenu(fileName = "Colours", menuName = "ScriptableObjects/ModelColours")]
public class ModelColours : ScriptableObject
{
    public Color[] colours;
}

