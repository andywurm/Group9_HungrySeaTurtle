using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContInfo2 : MonoBehaviour
{
  public GameObject DisplayInfo;
  public GameObject DisplayInfo2;

  public void ContinueGame(){
    DisplayInfo.SetActive(false);
    DisplayInfo2.SetActive(true);
  }
}
