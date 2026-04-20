using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Video;

public class DemoScript : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public ItemData[] itemsToPickup;

    public void PickupItem(int id)
    {
    
        inventoryManager.AddItem(itemsToPickup[id]);
    }
}
