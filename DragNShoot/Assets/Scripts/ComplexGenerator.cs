using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplexGenerator : MonoBehaviour
{
    public GameObject complex1;
    Vector3 location;
    private bool doIt = true;

    void Start()
    {
      location = new Vector3(0,50.5f,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ball" & doIt == true){
            Instantiate(complex1 , location , Quaternion.identity);
            doIt = false;
        }
    }
}
