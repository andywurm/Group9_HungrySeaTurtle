using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YesButton1 : MonoBehaviour
{

    public void wrongAnswer(){
      Lives.currentLives -= 1;
    }
}
