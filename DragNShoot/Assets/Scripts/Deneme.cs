using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
     {
        
        if(other.gameObject.tag == "Ball"){
            other.transform.SetParent(this.transform);
        }

        
        
        
        
    }


    
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "Ball"){
            other.transform.SetParent(null);
        }
    }
}
