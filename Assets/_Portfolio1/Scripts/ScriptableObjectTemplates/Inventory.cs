
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory", menuName = "/Inventory/Inventory")]
public class Inventory : ScriptableObject
{
    public string filter;
    public GameItem[] inventoryItems;
}
