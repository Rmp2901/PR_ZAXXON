using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaMovimiento : MonoBehaviour
{
    Vector3 vectorV;
    Vector3 vectorX;
    Vector3 vectorY;
    Vector3 vector1;
    Vector3 vector2;
    Vector3 vector3;
    Vector3 vector4;

    float speed = 5f;

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
        float desplX = Input.GetAxis("Horizontal") * speed;
        float desplY = Input.GetAxis("Vertical") * speed;
        /*vectorV = vectorX + vectorY;
        vectorY = new Vector3(0, transform.position.y, 0);
        vectorX = new Vector3(transform.position.x, 0, 0);*/
        transform.Translate(Vector3.right * Time.deltaTime * desplX);
        transform.Translate(Vector3.up * Time.deltaTime * desplY);
        /*print(vectorX);
        vector1 = new Vector3(transform.position.x, transform.position.y, 0);
        vector2 = new Vector3(-transform.position.x, transform.position.y, 0);
        vector3 = new Vector3(-transform.position.x, -transform.position.y, 0);
        vector4 = new Vector3(transform.position.x, -transform.position.y, 0);*/

        /*if (vectorV.magnitude > 20f)*/
        

    }
}
