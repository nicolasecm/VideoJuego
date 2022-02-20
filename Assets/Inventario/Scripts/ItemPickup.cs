using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public Item Item;

    void Pickup(){
        InvetoryManager.Instance.Add(Item);
    }


    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            Pickup();
        }
    }
}
