using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore.text = "HighScore: " + PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Counter.score > PlayerPrefs.GetInt("HighScore" , Counter.highScore)){
            PlayerPrefs.SetInt("HighScore" , Counter.highScore);
        }
    }

    
}
