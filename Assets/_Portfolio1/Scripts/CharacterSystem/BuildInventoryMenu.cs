using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildInventoryMenu : MonoBehaviour
{
    [SerializeField]
    private Inventory inventory;
    [SerializeField] private GameObject itemPrefab;
    private Transform buttonParent;
    private GameObject instantiatedItem;
    

    // Start is called before the first frame update
    void Start()
    {
        buttonParent = gameObject.transform;

        for (int i = 0; i < inventory.inventoryItems.Length; i++)
        {
            // Instantiate the template button under the parent object
            instantiatedItem = Instantiate(itemPrefab, buttonParent);
            // Access the attached ChangeItemDetails Script
           
        }
    }
}
