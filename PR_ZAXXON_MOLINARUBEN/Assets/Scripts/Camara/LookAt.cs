using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] Transform PointAt;
    [SerializeField] GameObject FollowPlayer;
    [SerializeField] float zOffset;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        MoverCamara();


    }

    void MoverCamara()
    {
        transform.LookAt(PointAt);



        float newX = FollowPlayer.transform.position.x;
        float newY = FollowPlayer.transform.position.y;
        float newZ = transform.position.z;

        transform.position = new Vector3(newX, newY + 5f, newZ);
    }


        

}
