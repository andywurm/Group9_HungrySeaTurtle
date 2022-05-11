using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TurtleCollision2 : MonoBehaviour
{

	  [SerializeField] GameObject DisplayGameover;

    void Update()
    {
      checkForLevel3();
      checkForEnd();
    }

    void checkForLevel3(){

      if(SceneManager.GetActiveScene().buildIndex == 2 && PersistentData.playerScore == 200){
        SceneManager.LoadScene(3);
      }

    }

    void checkForEnd(){

      if(PersistentData.playerScore == 300){
        SceneManager.LoadScene("End");
      }

    }

    public void OnTriggerEnter2D (Collider2D collider)
  {
      if(collider.gameObject.tag == "Fish"){

        //Code for adding to score goes here
        PersistentData.addToScore();
        hungerBar.Hunger += 20f;
        Destroy(collider.gameObject);

      }
      else if(collider.gameObject.tag == "theNet" ){

		    Destroy(collider.gameObject);
        DisplayGameover.SetActive(true);
        Time.timeScale = 0f;

	  }
  	else{

  		//Code for decreasing score goes here
      PersistentData.subtractScore();
  		Destroy(collider.gameObject);

  	  }
  }

}
