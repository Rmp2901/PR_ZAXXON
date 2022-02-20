using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioJuego : MonoBehaviour
{
    public float juegoSpeed;
    public float naveSpeed;
    bool alive;

    // Start is called before the first frame update
    void Start()
    {
        juegoSpeed = 20f;
        naveSpeed = 5f;
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            juegoSpeed += 0.01f;
        }

        float veloc = (juegoSpeed * 3600) / 1000;
        //speedText.text = "S: " + Mathf.Round(veloc) + "Km/h";
    }

    void Morir()
    {
        juegoSpeed = 0f;
        naveSpeed = 0f;
        alive = false;
    }
}
