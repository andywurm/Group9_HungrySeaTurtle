using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backToMenu : MonoBehaviour
{
   

   
	public void theEnd(){
		//PersistentData.Instance.SetScore(0);
		SceneManager.LoadScene("Menu");
		}

}
