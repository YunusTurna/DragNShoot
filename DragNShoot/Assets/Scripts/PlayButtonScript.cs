using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
    // Start is called before the first frame update

    void Awake()
    {
       
    }
    void Start()
    {

     
    }

    // Update is called once per frame
    void Update()
    {
        if(Dead.buttonDisplay == true)
        {
            gameObject.SetActive(true);
        }
        
    }
    public void PlayButton()
    {
        SceneManager.LoadScene("MainGame");
        Dead.makeCameraFreeze = false;
        Counter.score = 0;

    }
    public void CreditsButton(){
        SceneManager.LoadScene("Credits");
    }
    public void BackButton()
    {
        SceneManager.LoadScene("DeadScene");
    }
}
