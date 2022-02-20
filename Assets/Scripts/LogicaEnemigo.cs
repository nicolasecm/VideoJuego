using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEnemigo : MonoBehaviour
{
    public int vida;
    public int danoPuno;
    public int danoEspada;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "impactoEspada"){
            vida -= danoEspada;
        }
        if(other.gameObject.tag == "impactoPuno"){
            vida -= danoPuno;
        }
        if( vida <= 0){
            Destroy(gameObject);
        }
    }
}
