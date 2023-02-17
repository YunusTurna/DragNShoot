using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplexGenerator : MonoBehaviour
{
    
    
    public GameObject instantiator;
    Vector3 complex1tocomplex2;
    private bool doIt = true;
    [SerializeField] GameObject[] complexPlatformPrefab;
    private int random;
    
    
    
    
    
    

    void Start()
    {
      complex1tocomplex2 = new Vector3(0,instantiator.transform.position.y + 16.2f,0);
      random= Random.Range(0 , complexPlatformPrefab.Length);
      
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other){
        

        if(other.gameObject.tag == "Ball" & doIt == true){
            
            Instantiate(complexPlatformPrefab[random] , complex1tocomplex2 , Quaternion.identity);
            doIt = false;
        }
    }
}
