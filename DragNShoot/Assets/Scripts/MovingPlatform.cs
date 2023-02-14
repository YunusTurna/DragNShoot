using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragNNShoot;

public class MovingPlatform : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 hiz;
    private float speed = 2.5f;

    

    
    

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.right * speed;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
     
        if(other.gameObject.tag == "Wall")
        {
           speed = speed * -1;

        }

       



    
    
}
}