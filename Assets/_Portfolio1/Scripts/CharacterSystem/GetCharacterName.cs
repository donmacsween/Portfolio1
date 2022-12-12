using UnityEngine;
using TMPro;

public class GetCharacterName : MonoBehaviour
{
    [SerializeField] TMP_Text characterText; 
    [SerializeField] Character character;
    
    private void OnEnable()
    {
        characterText.text = character.characterName;
    }
}
