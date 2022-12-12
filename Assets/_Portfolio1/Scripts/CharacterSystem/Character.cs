using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

                        public  string          characterName;
                        public  bool            gender = true; // T for male F for female
    public HeadShapes currentHeadshapes;
    [SerializeField]    private GameObject      male;
    [SerializeField]    private GameObject      female;
    [SerializeField]    private GameObject      selectedModel;
    [SerializeField]    private int             coins =2000;
    [SerializeField]    private HairColours     availableHairColours;
    [SerializeField]    private EyeColors       availableEyeColours;
    [SerializeField]    private SkinColours     availableSkinTones;
    [SerializeField]    private Material        characterMaterial;
    
                        private int             selectedEyeColour   = 0;
                        private int             selectedHairColour  = 0;
                        private int             selectedSkinTone    = 0;

    public void SetCharacterName (string changedname)
    {
        characterName = changedname;
    }

    public void SetGender(bool selectedGender)
    {
        gender = selectedGender;
    if (gender) 
        {
           
            female.SetActive(false);
            male.SetActive(true);

        }
        else 
        {
            male.SetActive(false);
            female.SetActive(true);
        }

    }

    public void SetHairColor(int colourIndex)
    {
        selectedHairColour = colourIndex;
        characterMaterial.SetColor("_HAIRCOLOR", availableHairColours.colours[selectedHairColour]);
    }

    public void SetEyeColor(int colourIndex)
    {
        selectedEyeColour = colourIndex;
        characterMaterial.SetColor("_EYESCOLOR", availableEyeColours.colors[selectedEyeColour]);
    }

    public void SetSkinTone(int colourIndex)
    {
        selectedSkinTone = colourIndex;
        characterMaterial.SetColor("_EYESCOLOR", availableSkinTones.colors[selectedSkinTone]);
    }

}
