using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] GameObject Objeto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y, 180f);
        if (other.gameObject.name == "Cuerpo")
        {
            print("Ha chocao");
            Instantiate(Objeto, newPos, Quaternion.Euler(90f,0f,0f));
        }
    }
}
