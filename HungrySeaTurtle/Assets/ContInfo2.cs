using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContInfo2 : MonoBehaviour
{
  public GameObject DisplayInfo;

  public void ContinueGame(){
    DisplayInfo.SetActive(false);
    Time.timeScale = 1f;
  }
}
