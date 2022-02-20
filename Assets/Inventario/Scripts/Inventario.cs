using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{   
    public GameObject inventario;
    public InvetoryManager invMan;
    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)){
            if(inventario.activeSelf){
                inventario.SetActive(false);
                anim.SetBool("InvAbierto", false);
            }else{
                inventario.SetActive(true);
                invMan.ListItems();
                anim.SetBool("InvAbierto", true);
            }
        }
    }
}
