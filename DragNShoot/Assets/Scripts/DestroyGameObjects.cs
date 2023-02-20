using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObjects : MonoBehaviour
{
  [SerializeField] GameObject dead;
  Vector3 deadLocation;

  void Start()
  {
    deadLocation = new Vector3(transform.position.x , transform.position.y + 3 , transform.position.z);
  }
 
 private void OnTriggerEnter2D(Collider2D other)
{
  if(other.gameObject.tag == "Destroyer")
    {
            
      Destroy(gameObject);
      Instantiate(dead , deadLocation , Quaternion.identity );

    }
  
 }
    

    

    
    
    
    
}
