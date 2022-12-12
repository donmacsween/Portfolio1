using UnityEngine;
using UnityEngine.EventSystems;

namespace charactersystem
{
    public class ChangeHairColor : MonoBehaviour, IPointerClickHandler, ISubmitHandler
    {
        public int colourIndex = 0;
        [SerializeField]
        private HairColours hairColours;
        [SerializeField]
        private Material material;

        // Reacts to both pointer clicks
        public void OnPointerClick(PointerEventData eventData)
        {
            material.SetColor("_HAIRCOLOR", hairColours.colours[colourIndex]);
            Debug.Log(colourIndex.ToString());
        }

        // and "submit" key or button presses eg return or button A
        public void OnSubmit(BaseEventData eventData)
        {
            material.SetColor("_HAIRCOLOR", hairColours.colours[colourIndex]);
        }
    }
}