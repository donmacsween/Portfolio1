using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace charactersystem
{
    public class FaceSliderHandleNumber : MonoBehaviour
    {
        [SerializeField] private TMP_Text   handleText;
        [SerializeField] private Slider     slider;
        [SerializeField] private HeadShapes headShapes;
        [SerializeField] private SkinnedMeshRenderer       headMesh;

        public void Start()
        {
            slider.minValue = 0; 
            slider.maxValue = headShapes.shapes.Length-1;
        }

        public void SetGender (HeadShapes newHeadShape)
        {
            headShapes = newHeadShape;
            slider.maxValue = headShapes.shapes.Length - 1;
            slider.value = 0;
            handleText.text = "1";
            headMesh.sharedMesh = headShapes.shapes[0];
        }

        public void ChangeNumber(float number)
        {
            handleText.text = (number+1).ToString();
            headMesh.sharedMesh = headShapes.shapes[((uint)number)];
        }
    }
}
