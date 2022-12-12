using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField] private GameObject[] panels;

    public void TogglePanels(GameObject openPanels) 
    {
        foreach (GameObject panelHide in panels)
        {
            panelHide.SetActive(false);
        }
        
        openPanels.SetActive(true);
        
    }

}
