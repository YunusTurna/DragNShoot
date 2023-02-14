using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    
    [SerializeField] GameObject ball;
    [SerializeField] GameObject cams;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cams.transform.position = new Vector3(ball.transform.position.x , ball.transform.position.y , -10);
    }
}
