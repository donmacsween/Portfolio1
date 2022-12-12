/*  Author:  Don MacSween
    Purpose: Add this script to a Text Mesh Pro Text object to automatically get
             the title of the game as seen in the player setting if one is not provided.
*/
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class GetGameName : MonoBehaviour
 {  
    private TMP_Text title;

    private void Awake()
    {
        title = gameObject.GetComponent<TMP_Text>();
    }
    void OnEnable()
    {
        title.text = Application.productName;
    }
}
