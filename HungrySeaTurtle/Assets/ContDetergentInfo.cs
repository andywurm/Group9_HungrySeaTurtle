using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContDetergentInfo : MonoBehaviour
{
  public GameObject DisplayInfo;

  public void Detergent(){
    DisplayInfo.SetActive(false);
    Time.timeScale = 1f;
  }
}
