using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    
    [SerializeField] GameObject ball;
    [SerializeField] GameObject cams;
    Rigidbody2D rb;
    void Awake()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        rb = GetComponentInChildren<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Dead.makeCameraFreeze == false)
        {
            cams.transform.position = new Vector3(-10.87f , ball.transform.position.y , -10);
        }

        if(Dead.makeCameraFreeze == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
            Debug.Log("Camera Stop");
        }
    }
}
