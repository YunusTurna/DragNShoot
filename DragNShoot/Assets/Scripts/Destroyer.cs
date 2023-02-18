using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
   [SerializeField] GameObject ball;
   


   void Update()
   {
    transform.position = new Vector3(transform.position.x , ball.transform.position.y -30 , ball.transform.position.z);
   }
}
