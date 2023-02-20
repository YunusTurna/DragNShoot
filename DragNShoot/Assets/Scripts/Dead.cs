using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    public static bool makeCameraFreeze = false;
    public static int Y;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
      if(other.gameObject.tag == "Ball")
      {
        Debug.Log("Dead");
        Destroy(gameObject);
        makeCameraFreeze = true;

      }
    }
}
