using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerArmas : MonoBehaviour{
    public BoxCollider[] armasBoxCol;
    public BoxCollider punoBoxCol;
    public GameObject[] armas;
    public LogicaPersonaje logicaP;

    void Start(){
        DesactivarCollidersArmas();
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Alpha9)){
            DesactivarArmas();
        }
    }

    public void ActivarArma(int numero){
        for(int i = 0; i < armas.Length; i++){
            armas[i].SetActive(false);
        }
        armas[numero].SetActive(true);
        logicaP.anim.SetBool("conEspada", true);
    }

    public void GuardarArma(int numero){
        if (logicaP.conEspada){
            
        }
    }

    public void DesactivarArmas(){
        for(int i = 0; i < armas.Length; i++){
            armas[i].SetActive(false);
        }
        logicaP.anim.SetBool("conEspada", false);
    }

    public void ActivarCollidersArmas(){
        for (int i = 0; i < armasBoxCol.Length; i++){
            if(logicaP.anim.GetBool("conEspada")){
                if (armasBoxCol[i] != null){
                    armasBoxCol[i].enabled = true;
                }
            }else{
                punoBoxCol.enabled = true;
            }
        }
    }

    public void DesactivarCollidersArmas(){
        for (int i = 0; i < armasBoxCol.Length; i++){
            if (armasBoxCol[i] != null){
                armasBoxCol[i].enabled = false;
            }
        }
        punoBoxCol.enabled = false;
    }
}
