using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    Item item;
    public Button RemoveButton;
    
    public void RemoveItem(){
        InvetoryManager.Instance.Remove(item);

        Destroy(gameObject);
    }

    public void AddItem(Item newItem){
        item = newItem;
    }

    public void UseItem(){
        switch (item.itemType)
        {
            case Item.ItemType.Pocion:
                LogicPlayerItems.Instance.IncrementarVida(item.value);
                break;
            case Item.ItemType.Libro:
                LogicPlayerItems.Instance.IncrementarExp(item.value);
                break;
        }
        RemoveItem();
    }
}
