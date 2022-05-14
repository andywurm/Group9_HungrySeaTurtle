using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cont3 : MonoBehaviour
{
  public GameObject DisplayInfo;

  public void ContinueGame(){
    DisplayInfo.SetActive(false);
    Time.timeScale = 1f;
  }
}
