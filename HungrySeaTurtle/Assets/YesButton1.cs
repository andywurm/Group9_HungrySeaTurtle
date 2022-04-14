using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YesButton1 : MonoBehaviour
{

    public GameObject DecideDemo;
    
    public void wrongAnswer(){
      Lives.currentLives -= 1;
      DecideDemo.SetActive(false);
      Time.timeScale = 1f;
    }
}
