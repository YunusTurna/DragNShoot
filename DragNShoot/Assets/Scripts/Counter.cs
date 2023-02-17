using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public static int score;
    [SerializeField] GameObject counter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Ball")
        {
            score = score + 1;
            Debug.Log(score);
            counter.SetActive(false);
        }
    }
}
