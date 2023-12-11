using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagercontrol : MonoBehaviour
{
    public int punto;
    public Text puntosdetexto;
    public void Start()
    {
        Sumarpuntos(0);
    }
    public void Sumarpuntos(int puntos)
    {
        punto = puntos + punto;
        puntosdetexto.text = "Puntos: " + punto;
            
    }
}
