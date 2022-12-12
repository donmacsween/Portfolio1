using UnityEngine;
using UnityEngine.UI;
namespace charactersystem
{
    public class BuildEyeColourMenu : MonoBehaviour
    {
        [SerializeField]
        private EyeColors eyeColours;
        [SerializeField]
        private GameObject buttonPrefab;
        private Transform buttonParent;
        private GameObject instantiatedButton;
        private ChangeEyeColor eyeColorScript;
        private Image buttonImage;

        // Start is called before the first frame update
        void Start()
        {
            buttonParent = gameObject.transform;

            for (int i = 0; i < eyeColours.colors.Length; i++)
            {
                // Instantiate the template button under the parent object
                instantiatedButton = Instantiate(buttonPrefab, buttonParent);
                // Access the attached ChangeSkinTone Script
                eyeColorScript = instantiatedButton.GetComponent<ChangeEyeColor>();
                // Set the public integer that relates to the skin tone defined in the SkinColors scriptable object
                eyeColorScript.colourIndex = i;
                // Access the image of the tempate button
                buttonImage = instantiatedButton.GetComponent<Image>();
                // and change the color to match the skin tone defined in the SkinColors scriptable object at the current index
                buttonImage.color = eyeColours.colors[i];
            }
        }
    }
}