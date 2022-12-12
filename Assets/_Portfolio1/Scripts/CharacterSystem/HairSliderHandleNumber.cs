using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace charactersystem
{
    public class HairSliderHandleNumber : MonoBehaviour
    {
        [SerializeField] private TMP_Text handleText;
        [SerializeField] private Slider slider;
        [SerializeField] private HairShapes hairShapes;
        [SerializeField] private SkinnedMeshRenderer hairMesh;

        public void Start()
        {
            slider.minValue = 0;
            slider.maxValue = hairShapes.shapes.Length - 1;
        }

        public void SetGender(HairShapes newHairShape)
        {
            hairShapes = newHairShape;
            slider.maxValue = hairShapes.shapes.Length - 1;
            slider.value = 0;
            handleText.text = "1";
            hairMesh.sharedMesh = hairShapes.shapes[0];
        }

        public void ChangeNumber(float number)
        {
            handleText.text = (number + 1).ToString();
            hairMesh.sharedMesh = hairShapes.shapes[((uint)number)];
        }
    }
}
