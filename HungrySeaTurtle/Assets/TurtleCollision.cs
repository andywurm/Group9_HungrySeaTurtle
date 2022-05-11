using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TurtleCollision : MonoBehaviour
{

    [SerializeField] GameObject DisplayBoxInfo;
    [SerializeField] GameObject DisplayStrawInfo;
    [SerializeField] GameObject DisplayDetergentInfo;
    [SerializeField] GameObject DisplayBottleInfo;
	  [SerializeField] GameObject DisplayGameover;
    private bool firstBottle = false;
    private bool firstGlassBottle = false;
    private bool firstGlassBottle2 = false;
    private bool firstBox = false;
    private bool firstStraw = false;
    private bool firstDetergent = false;
    private bool firstCup = false;
    private bool firstJar = false;
    private bool firstCan = false;


    void Update()
    {
      checkForNextLevel();
    }

    void checkForNextLevel(){
      if(PersistentData.playerScore == 100){
        SceneManager.LoadScene("Level2");
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
      else if(collider.gameObject.tag == "Box" && firstBox == false) {

        //Code for decreasing score goes here
        if(PersistentData.playerScore != 0){
          PersistentData.subtractScore();
        }

        Destroy(collider.gameObject);
        DisplayBoxInfo.SetActive(true);
        Time.timeScale = 0f;
        firstBox = true;

      }
      else if(collider.gameObject.tag == "Straw" && firstStraw == false) {

        //Code for decreasing score goes here
        if(PersistentData.playerScore != 0){
          PersistentData.subtractScore();
        }

        Destroy(collider.gameObject);
        DisplayStrawInfo.SetActive(true);
        Time.timeScale = 0f;
        firstStraw = true;

      }
      else if(collider.gameObject.tag == "Detergent" && firstDetergent == false) {

        //Code for decreasing score goes here
        if(PersistentData.playerScore != 0){
          PersistentData.subtractScore();
        }

        Destroy(collider.gameObject);
        DisplayDetergentInfo.SetActive(true);
        Time.timeScale = 0f;
        firstDetergent = true;

      }
      else if(collider.gameObject.tag == "Bottle" && firstBottle == false){

        //Code for decreasing score goes here
        if(PersistentData.playerScore != 0){
          PersistentData.subtractScore();
        }

        Destroy(collider.gameObject);
        DisplayBottleInfo.SetActive(true);
        Time.timeScale = 0f;
        firstBottle = true;

      }
      else if(collider.gameObject.tag == "GlassBottle" && firstGlassBottle == false){

        //Code for decreasing score goes here
        if(PersistentData.playerScore != 0){
          PersistentData.subtractScore();
        }

        Destroy(collider.gameObject);
        DisplayBottleInfo.SetActive(true);
        Time.timeScale = 0f;
        firstGlassBottle = true;

      }
      else if(collider.gameObject.tag == "GlassBottle2" && firstGlassBottle2 == false){

        //Code for decreasing score goes here
        if(PersistentData.playerScore != 0){
          PersistentData.subtractScore();
        }

        Destroy(collider.gameObject);
        DisplayBottleInfo.SetActive(true);
        Time.timeScale = 0f;
        firstGlassBottle2 = true;

      }
      else if(collider.gameObject.tag == "Cup" && firstCup == false){

        //Code for decreasing score goes here
        if(PersistentData.playerScore != 0){
          PersistentData.subtractScore();
        }

        Destroy(collider.gameObject);
        DisplayBottleInfo.SetActive(true);
        Time.timeScale = 0f;
        firstCup = true;

      }
      else if(collider.gameObject.tag == "Can" && firstCan == false){

        //Code for decreasing score goes here
        if(PersistentData.playerScore != 0){
          PersistentData.subtractScore();
        }

        Destroy(collider.gameObject);
        DisplayBottleInfo.SetActive(true);
        Time.timeScale = 0f;
        firstCan = true;

      }
      else if(collider.gameObject.tag == "Jar" && firstJar == false){

        //Code for decreasing score goes here
        if(PersistentData.playerScore != 0){
          PersistentData.subtractScore();
        }

        Destroy(collider.gameObject);
        DisplayBottleInfo.SetActive(true);
        Time.timeScale = 0f;
        firstJar = true;

      }
      else if(collider.gameObject.tag == "theNet" ){

		    Destroy(collider.gameObject);
        DisplayGameover.SetActive(true);
        Time.timeScale = 0f;

	  }

	else{

		//Code for decreasing score goes here
    if(PersistentData.playerScore != 0){
      PersistentData.subtractScore();
    }
		Destroy(collider.gameObject);

	  }

  }

}
