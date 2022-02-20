using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicPlayerItems : MonoBehaviour
{
    public static LogicPlayerItems Instance;
    public int Health;
    public int Exp;

    private void Awake() {
        Instance = this;
    }

    public void IncrementarVida(int value){
        Health += value;
    }
    public void IncrementarExp(int value){
        Health += value;
    }
}
