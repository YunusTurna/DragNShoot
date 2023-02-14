using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraJumpPlatform : MonoBehaviour
{
    [SerializeField] private GameObject ball;

    Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ball")
        {
          
        }
    }
}
