
using UnityEngine;
using UnityEngine.UI;
namespace charactersystem 
{
    public class BuildSkinToneMenu : MonoBehaviour
    {
        [SerializeField]
        private SkinColours     skinColours;
        [SerializeField]
        private GameObject      buttonPrefab;
        private Transform       buttonParent;
        private GameObject      instantiatedButton;
        private ChangeSkinTone  skinToneScript;
        private Image           buttonImage;

        // Start is called before the first frame update
        void Start()
        {
            buttonParent = gameObject.transform;

            for (int i = 0; i < skinColours.colors.Length; i++)
            {
                // Instantiate the template button under the parent object
                instantiatedButton = Instantiate(buttonPrefab,buttonParent);
                // Access the attached ChangeSkinTone Script
                skinToneScript = instantiatedButton.GetComponent<ChangeSkinTone>();
                // Set the public integer that relates to the skin tone defined in the SkinColors scriptable object
                skinToneScript.colourIndex = i;
                // Access the image of the tempate button
                buttonImage = instantiatedButton.GetComponent<Image>();
                // and change the color to match the skin tone defined in the SkinColors scriptable object at the current index
                buttonImage.color = skinColours.colors[i];
            }
        }
    }
}
