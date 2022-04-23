using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContStrawInfo : MonoBehaviour
{
  public GameObject DisplayInfo;

  public void Straw(){
    DisplayInfo.SetActive(false);
    Time.timeScale = 1f;
  }

}
