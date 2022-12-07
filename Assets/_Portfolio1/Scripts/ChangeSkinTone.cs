using UnityEngine;
using UnityEngine.EventSystems;

namespace charactersystem
{
    public class ChangeSkinTone : MonoBehaviour, IPointerClickHandler, ISubmitHandler
    {
        public int colourIndex = 0;
        [SerializeField]
        private SkinColours skinColours;
        [SerializeField]
        private Material material;

        // Reacts to both pointer clicks
        public void OnPointerClick(PointerEventData eventData)
        {
            material.SetColor("_SKINCOLOR", skinColours.colors[colourIndex]);
        }

        // and "submit" key or button presses eg return or button A
        public void OnSubmit(BaseEventData eventData)
        {
            material.SetColor("_SKINCOLOR", skinColours.colors[colourIndex]);
        }
    }
}
