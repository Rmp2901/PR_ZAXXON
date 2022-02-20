using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour
{
    [SerializeField] GameObject Columna;
    [SerializeField] Transform instantiatePos;
    float intervalo;
    [SerializeField] float distancia;
    public InicioJuego inicioJuego;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        //intervalo = 0.5f;
        distancia = 10f;
        inicioJuego = GameObject.Find("InicioJuego").GetComponent<InicioJuego>();
        
        StartCoroutine("CrearObstaculo");
    }

    // Update is called once per frame
    void Update()
    {
        speed = inicioJuego.juegoSpeed;
    }

    IEnumerator CrearObstaculo()
    {
        while (true)
        {

            speed = inicioJuego.juegoSpeed;
            intervalo = distancia / speed;
           
            float randomX = Random.Range(-18f, 18f);
            float randomY = Random.Range(-18f, 18f);
            Vector3 newPos = new Vector3(randomX, randomY, instantiatePos.position.z);
            Instantiate(Columna, newPos, Quaternion.identity);

            

            yield return new WaitForSeconds(intervalo);
        }
    }
    public void Parar()
    {
        StopCoroutine("CrearObstaculo");
        speed = 0f;
    }
}
