using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Video;

public class DemoScript : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public ItemData[] itemsToPickup;

    public void PickupItem(int id)
    {
    
        bool result = inventoryManager.AddItem(itemsToPickup[id]);
        if(result == true)
        {
            Debug.Log("item added");
        }
        else
        {
            Debug.Log("Item not added");
        }
    }
}
