using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquiparArma : MonoBehaviour
{

    public RecogerArmas recogerA;
    public int numeroArma;
    // Start is called before the first frame update
    void Start()
    {
        recogerA = GameObject.FindGameObjectWithTag("Player").GetComponent<RecogerArmas>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            recogerA.ActivarArma(numeroArma);
            Destroy(gameObject);
        }
    }
}
