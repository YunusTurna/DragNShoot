using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DragNNShoot{
public class DragNShoot : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody2D rb;

    [SerializeField] private GameObject SpawnNormalPlatform;

    

    private Transform originalParent;

    public Vector2 minPower , maxpower;

    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;
    Vector3 spawnExtraJumpPlatform;
    Vector3 platformRotation;
    [SerializeField] GameObject ExtraJumpPlatformm;

    private bool shoot = true;
    private bool extraJumped = false;
    private int extraJumpedCounter = 1;

    LineTrajectory tl;

    private void Start()
    {
        cam = Camera.main;
        tl = GetComponent<LineTrajectory>();
        originalParent = transform.parent;
        spawnExtraJumpPlatform = new Vector3(ExtraJumpPlatformm.transform.position.x , ExtraJumpPlatformm.transform.position.y + 5f , ExtraJumpPlatformm.transform.position.z);
        platformRotation = new Vector3(0,0,0);
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
            Instantiate(SpawnNormalPlatform , spawnExtraJumpPlatform , Quaternion.identity );
            extraJumped = false;
            extraJumpedCounter = extraJumpedCounter -1;

        }


      

        

        
    }


   private void OnCollisionEnter2D(Collision2D other)
   {
    if(other.gameObject.tag == "Ground" || other.gameObject.tag == "Platform")
    {
        shoot = true;
        rb.drag = 0.5F;
        

    }

    if(other.gameObject.tag == "ExtraJump"){
        rb.velocity = new Vector3(0,0,0);
        rb.AddForce(new Vector2(0,30) , ForceMode2D.Impulse);
        rb.drag = 0.5F;
        if(extraJumpedCounter == 1){
            extraJumped = true;
        }
        

    }
    

    

    
   }
   
   

   

    
    

    


}
}
