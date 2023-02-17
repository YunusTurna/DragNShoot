using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    
    [SerializeField] GameObject ball;
    [SerializeField] GameObject cams;
    void Awake()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        cams.transform.position = new Vector3(-10.87f , ball.transform.position.y , -10);
    }
}
