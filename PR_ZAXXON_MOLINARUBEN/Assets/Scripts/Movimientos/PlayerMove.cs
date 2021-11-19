using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Vector3 InitPos = new Vector3(0f, 0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        transform.position = InitPos;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 destPos = new Vector3(-1f, 0f, 0f);
        InitPos = InitPos + destPos;
        transform.position = InitPos;
    }
}
