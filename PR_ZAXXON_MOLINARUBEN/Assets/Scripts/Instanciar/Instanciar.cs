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
       
    }

    IEnumerator CrearObstaculo()
    {
        while (true)
        {
            float speed;
            speed = inicioJuego.juegoSpeed;
            intervalo = distancia / speed;
           
            float randomX = Random.Range(-20f, 20f);
            Vector3 newPos = new Vector3(randomX, instantiatePos.position.y, instantiatePos.position.z);
            Instantiate(Columna, newPos, Quaternion.identity);

            

            yield return new WaitForSeconds(intervalo);
        }
    }
}
