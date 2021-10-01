using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float rotationspeed = 100f;

    [SerializeField] float limiteH = 20f;
    [SerializeField] float limiteV = 1f;
    [SerializeField] float limiteV2 = 20f;
 

    // Update is called once per frame
    void Update()
    {
        float posX = transform.position.x;
        float posY = transform.position.y;

        float desplY = Input.GetAxis("Vertical") * speed;
        float desplX = Input.GetAxis("Horizontal") * speed;
        

        float desplR = Input.GetAxis("Rotation");
        transform.Rotate(0f, 0f, desplR * Time.deltaTime * -rotationspeed);

        
       
        
        if (Input.GetButtonDown("Fire3"))
        {
            print("Se ha disparado");
        }
        /*
        if (posX > limiteH && desplX > 0f)
        {
            transform.position = new Vector3(posX, transform.position.y, transform.position.z);
        }

        else if (posX < -limiteH && desplX < 0f)
        {
            transform.position = new Vector3(posX, transform.position.y, transform.position.z);
        }
        */

        if((posX < limiteH || desplX < 0f) && (posX > -limiteH || desplX > 0f))
        {
            transform.Translate(Vector3.right * desplX * Time.deltaTime, Space.World);
        }

        if ((posY < limiteV2 || desplY < 0f) && (posY > limiteV || desplY > 0f))
        {
            transform.Translate(Vector3.up * desplY * Time.deltaTime, Space.World);
        }



        

    }
}
