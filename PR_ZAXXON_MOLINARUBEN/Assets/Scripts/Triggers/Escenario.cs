using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escenario : MonoBehaviour
{
    float speed;
    public InicioJuego inicioJuego;
   
    // Start is called before the first frame update
    void Start()
    {
        inicioJuego = GameObject.Find("InicioJuego").GetComponent<InicioJuego>();
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = inicioJuego.juegoSpeed;
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        if (transform.position.z < -30f)
        {
            Destroy(gameObject);
        }
    }

    
}
