using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContBoxInfo : MonoBehaviour
{
  public GameObject DisplayInfo;

  public void Box(){
    DisplayInfo.SetActive(false);
    Time.timeScale = 1f;
  }

}
