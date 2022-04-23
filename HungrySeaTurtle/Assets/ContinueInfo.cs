using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueInfo : MonoBehaviour
{
  public GameObject DisplayInfo;

  public void Bottle(){
    DisplayInfo.SetActive(false);
    Time.timeScale = 1f;
  }
}
