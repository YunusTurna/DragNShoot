using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    public static bool makeCameraFreeze = false;
    
    private bool startC = false;
    public static bool buttonDisplay = false;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(startC == true){
          StartCoroutine(Wait());
          startC = false;
          SceneManager.LoadScene("DeadScene");
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
     {
      if(other.gameObject.tag == "Ball")
      {
        Debug.Log("Dead");
        Destroy(gameObject);
        makeCameraFreeze = true;
        startC = true;
        buttonDisplay = true;
        

      }
    }
    IEnumerator Wait()
    {
      yield return new WaitForSeconds(1);
    }
}
