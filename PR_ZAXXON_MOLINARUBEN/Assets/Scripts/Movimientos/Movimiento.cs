using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float rotationspeed = 100f;

    
 

    // Update is called once per frame
    void Update()
    {
        float posX = transform.position.x;
        float posY = transform.position.y;

        float desplY = Input.GetAxis("Vertical") * speed;
        float desplX = Input.GetAxis("Horizontal") * speed;
        

        float desplR = Input.GetAxis("Rotation");
        transform.Rotate(0f, 0f, desplR * Time.deltaTime * -rotationspeed);

        
       
        
        









        

    }
}
