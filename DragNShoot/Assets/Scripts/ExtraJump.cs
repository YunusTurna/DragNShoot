using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraJump : MonoBehaviour
{

    [SerializeField] GameObject extraJumpPlatform;
    [SerializeField] GameObject normalPlatform;
    private bool doit = false;
    private int once = 1;
    
    Vector3 location;


    // Start is called before the first frame update
    void Start()
    {
        location = new Vector3(extraJumpPlatform.transform.position.x , extraJumpPlatform.transform.position.y + 9 , extraJumpPlatform.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(doit == true)
        {
            StartCoroutine(Wait());
            doit = false;
            
            
            
        }
    }

    
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if(other.gameObject.tag  == "Ball"){
            normalPlatform.SetActive(false);
            doit = true;
            
           
        }
        
        
        
    }
    IEnumerator Wait(){
        normalPlatform.SetActive(true);
        yield return new WaitForSeconds(2);
        Instantiate(normalPlatform , location, Quaternion.identity );
        
    }
}
