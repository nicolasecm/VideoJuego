using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float VelocidadInicial = 5.0f;
    public float VelocidadEspada = 1.0f;
    public float velocidadRotacion = 200.0f;
    public int velCorrer;
    public float x,y;
    public float fuerzaSalto = 8.0f;
    public Rigidbody rb;
    public bool puedoSaltar;
    public bool atacando;
    public bool avanzoSolo;
    public bool conEspada;
    public float impulsoGolpe = 10f;
    public Animator anim;

    void Start(){
        puedoSaltar = false;
        anim = GetComponent<Animator>();
    }

    void FixedUpdate() {
        if (!atacando){
            transform.Rotate(0, x*Time.deltaTime*velocidadRotacion, 0);
            transform.Translate(0, 0, y*Time.deltaTime*velocidadMovimiento);
        }
        if (avanzoSolo){
            rb.velocity= transform.forward * impulsoGolpe;
        }
    }

    void Update(){
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if(Input.GetKeyDown(KeyCode.Mouse0) && puedoSaltar && !atacando){
            if(anim.GetBool("conEspada")){
                anim.SetTrigger("GolpeEspada");
                atacando = true;
            }else{
                anim.SetTrigger("GolpePuño");
                atacando = true;
            }
        }

        if (puedoSaltar){
            if(!atacando){
                if(Input.GetKeyDown(KeyCode.Space)){
                anim.SetBool("Salte", true);
                rb.AddForce(new Vector3(0,fuerzaSalto,0),ForceMode.Impulse);
            }
            anim.SetBool("TocarSuelo", true);
            }
        }else{
            isFalling();
        }

        if(anim.GetBool("conEspada")){
            velocidadMovimiento = VelocidadEspada;
        }else{
            velocidadMovimiento = VelocidadInicial;
        }

        if(Input.GetKey(KeyCode.LeftShift) && puedoSaltar){
            if(!atacando){
                velocidadMovimiento = velCorrer;
                if (y > 0){
                    anim.SetBool("Correr", true);
                }else{
                    anim.SetBool("Correr", false);
                }
            }
        }else{
            anim.SetBool("Correr", false);
            if(puedoSaltar){
                velocidadMovimiento = VelocidadInicial;
            }
        }
    }

    public void isFalling(){
        anim.SetBool("TocarSuelo", false);
        anim.SetBool("Salte", false);
    }

    public void dejarGolpear(){
        atacando = false;
    }

    public void AvanzarSolo(){
        avanzoSolo = true;
    }

    public void dejarAvanzar(){
        avanzoSolo = false;
    }
}
