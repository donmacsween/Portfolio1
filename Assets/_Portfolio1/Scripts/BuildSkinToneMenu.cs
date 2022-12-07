using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace charactersystem 
{
    public class BuildSkinToneMenu : MonoBehaviour
    {
        [SerializeField]
        private SkinColours skinColours;
        [SerializeField]
        private GameObject buttonPrefab;
        private Transform buttonParent;
        



        // Start is called before the first frame update
        void Start()
        {
            buttonParent = gameObject.transform;

            for (int i = 0; i < skinColours.colors.Length; i++)
            {
                GameObject go = Instantiate(buttonPrefab, buttonParent) as GameObject;
                ChangeSkinTone cst = go.GetComponent<ChangeSkinTone>();
                cst.colourIndex = i;
                Image img = go.GetComponent<Image>();
                img.color = skinColours.colors[i];
            }
        }

    }
}
