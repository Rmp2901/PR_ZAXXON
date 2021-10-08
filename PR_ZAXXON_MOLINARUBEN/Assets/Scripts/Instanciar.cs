using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour
{
    [SerializeField] GameObject Columna;
    [SerializeField] Transform instantiatePos;
    float intervalo;


    // Start is called before the first frame update
    void Start()
    {
        intervalo = 0.5f;
        StartCoroutine("CrearObstaculo");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -10f)
        {
            Destroy(Columna);
        }
    }

    IEnumerator CrearObstaculo()
    {
        while (true)
        {
            print("Hola");
            float randomX = Random.Range(-20f, 20f);
            Vector3 newPos = new Vector3(randomX, instantiatePos.position.y, instantiatePos.position.z);
            Instantiate(Columna, newPos, Quaternion.identity);

            

            yield return new WaitForSeconds(intervalo);
        }
    }
}
