using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f,-30f * Time.deltaTime,Space.Self);
    }
}
