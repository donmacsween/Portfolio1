using UnityEngine;
using UnityEngine.UI;
namespace charactersystem
{
    public class BuildHairColourMenu : MonoBehaviour
    {
        [SerializeField]
        private HairColours hairColours;
        [SerializeField]
        private GameObject buttonPrefab;
        private Transform buttonParent;
        private GameObject instantiatedButton;
        private ChangeHairColor hairColorScript;
        private Image buttonImage;

        // Start is called before the first frame update
        void Start()
        {
            buttonParent = gameObject.transform;

            for (int i = 0; i < hairColours.colours.Length; i++)
            {
                // Instantiate the template button under the parent object
                instantiatedButton = Instantiate(buttonPrefab, buttonParent);
                // Access the attached ChangeSkinTone Script
                hairColorScript = instantiatedButton.GetComponent<ChangeHairColor>();
                // Set the public integer that relates to the skin tone defined in the SkinColors scriptable object
                hairColorScript.colourIndex = i;
                // Access the image of the tempate button
                buttonImage = instantiatedButton.GetComponent<Image>();
                // and change the color to match the skin tone defined in the SkinColors scriptable object at the current index
                buttonImage.color = hairColours.colours[i];
            }
        }
    }
}