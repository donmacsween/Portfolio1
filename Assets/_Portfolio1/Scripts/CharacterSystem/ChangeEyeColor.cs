using UnityEngine;
using UnityEngine.EventSystems;

namespace charactersystem
{
    public class ChangeEyeColor : MonoBehaviour, IPointerClickHandler, ISubmitHandler
    {
        public int colourIndex = 0;
        [SerializeField]
        private EyeColors eyeColours;
        [SerializeField]
        private Material material;

        // Reacts to both pointer clicks
        public void OnPointerClick(PointerEventData eventData)
        {
            material.SetColor("_EYESCOLOR", eyeColours.colors[colourIndex]);
            Debug.Log(colourIndex.ToString());
        }

        // and "submit" key or button presses eg return or button A
        public void OnSubmit(BaseEventData eventData)
        {
            material.SetColor("_EYESCOLOR", eyeColours.colors[colourIndex]);
        }
    }
}