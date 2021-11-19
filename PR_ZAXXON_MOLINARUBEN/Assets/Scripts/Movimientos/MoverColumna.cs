using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverColumna : MonoBehaviour
{
    float speed;

    public InicioJuego inicioJuego;


    // Start is called before the first frame update
    void Start()
    {
        inicioJuego = GameObject.Find("InicioJuego").GetComponent<InicioJuego>();
        speed = inicioJuego.juegoSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        if (transform.position.z < -10f)
        {
            Destroy(gameObject);
        }
        
    }
}
