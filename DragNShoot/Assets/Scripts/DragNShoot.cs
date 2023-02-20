using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace DragNNShoot{
public class DragNShoot : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody2D rb;

    
   
    
    [SerializeField] private GameObject complexPlatform1;
    [SerializeField] private GameObject complexPlatform2;
    [SerializeField] private GameObject instance;
    
    

    

    private Transform originalParent;
    private int bekle = 5;
    private bool bekleCalistir = false;

    public Vector2 minPower , maxpower;

    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;
    Vector3 spawnExtraJumpPlatform;
    Vector3 platformRotation;
   
    

    private bool shoot = true;
    private bool extraJumped = false;
    private int extraJumpedCounter = 1;
    private bool makeItStop = false;

    LineTrajectory tl;

    private void Awake()
    {
        cam = Camera.main;
        tl = GetComponent<LineTrajectory>();
        originalParent = transform.parent;
        
        
        
        
    }

    void Update()
    {
        if(shoot == true)
        {
        
        
        if(Input.GetMouseButtonDown(0))
        {
            startPoint =cam.ScreenToWorldPoint(Input.mousePosition);
            startPoint.z = 15;

        }

        if(Input.GetMouseButton(0))
        {
          Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
          currentPoint.z = 15;
          tl.RenderLine(startPoint , currentPoint);
        }
        if(Input.GetMouseButtonUp(0))
        {
            endPoint =cam.ScreenToWorldPoint(Input.mousePosition);
            endPoint.z = 15;

            force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x , minPower.x, maxpower.x),Mathf.Clamp(startPoint.y - endPoint.y , minPower.y, maxpower.y));
            rb.AddForce(force * power , ForceMode2D.Impulse);
            tl.EndLine();
            shoot = false;
        }
        }

        if(extraJumped == true & rb.velocity.y <= 0)
        {
            
            extraJumped = false;
            extraJumpedCounter = extraJumpedCounter -1;

        }
        if(makeItStop == true)
        {
            StartCoroutine(Wait(bekle));
            if(bekleCalistir == true)
            {
            Debug.Log("Çalışıyor");
            gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            }

        }
        

      

        

        
    }


   private void OnCollisionEnter2D(Collision2D other)
   {
    if((other.gameObject.tag == "Ground" || other.gameObject.tag == "Platform") || other.gameObject.tag == "Instance")
    {
        shoot = true;
        rb.drag = 0.5F;
        

    }

    if(other.gameObject.tag == "ExtraJump"){

        
        
        rb.velocity = new Vector3(0,0,0);
        rb.AddForce(new Vector2(0,20) , ForceMode2D.Impulse);
        rb.drag = 0.5F;
        if(extraJumpedCounter == 1){
            extraJumped = true;
        }
    
    }
    if(other.gameObject.tag == "Dead")
    {
       {
        makeItStop = true;

        }
   }
   }
   
   IEnumerator Wait(int bekle)
   {
    yield return new WaitForSeconds(bekle);
    bekleCalistir = true;
   }
   
   

   

    
    

    


}
}
