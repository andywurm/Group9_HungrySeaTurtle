using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoButton1 : MonoBehaviour
{

  public GameObject DecideDemo;

  public void rightAnswer(){
    DecideDemo.SetActive(false);
    Time.timeScale = 1f;
  }
}
