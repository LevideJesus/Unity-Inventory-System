using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject inventoryItemPrefab;
    public InventorySlot[] inventorySlots;

   public bool AddItem(ItemData item)
   {
    for(int i = 0; i < inventorySlots.Length; i++)
    {
        InventorySlot slot = inventorySlots[i];

        if (slot == null)
        {
            continue;
        }

        InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();

        if(itemInSlot == null)
        {
            
            SpawnNewItem(item, slot);
            return true;
        }
        
   }
    return false;
    void SpawnNewItem(ItemData item, InventorySlot slot)
    {
        
    GameObject newItemGo = Instantiate(inventoryItemPrefab, slot.transform);

    InventoryItem inventoryItem = newItemGo.GetComponent<InventoryItem>();

    if (inventoryItem == null)
    {
        return;
    }

    if (inventoryItem.image == null)
    {
        return;
    }

    if (item.icon == null)
    {
        return;
    }
    inventoryItem.InitialiseItem(item);

    }
    
}
}
