using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverColumna : MonoBehaviour
{
    float speed;
    


    // Start is called before the first frame update
    void Start()
    {
        speed = 20f;
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