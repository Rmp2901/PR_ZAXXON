using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaMovimiento : MonoBehaviour
{

    float speed;

    public InicioJuego inicioJuego;
    public Instanciar instanciar;
    float rotationSpeed = 100f;


    // Start is called before the first frame update
    void Start()
    {
        inicioJuego = GameObject.Find("InicioJuego").GetComponent<InicioJuego>();
        speed = inicioJuego.naveSpeed;
        instanciar = GameObject.Find("Instanciador").GetComponent<Instanciar>();

    }

    // Update is called once per frame
    void Update()
    {
        float desplX = Input.GetAxis("Horizontal") * 20f;
        float desplY = Input.GetAxis("Vertical") * 20f;

        transform.Translate(Vector3.right * Time.deltaTime * desplX);
        transform.Translate(Vector3.up * Time.deltaTime * desplY);

        float desplR = Input.GetAxis("Rotation");
        transform.Rotate(0f, 0f, desplR * Time.deltaTime * -rotationSpeed);



    }
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstaculo")
        {
            inicioJuego.SendMessage("Morir");
            
            instanciar.SendMessage("Parar");
            GameObject.Find("Nave").SetActive(false);
        }
    }
    
        
    
}
