using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleCollision : MonoBehaviour
{

    [SerializeField] GameObject DisplayBoxInfo;
    [SerializeField] GameObject DisplayStrawInfo;
    [SerializeField] GameObject DisplayDetergentInfo;
    [SerializeField] GameObject DisplayBottleInfo;
    private bool firstBottle = false;
    private bool firstBox = false;
    private bool firstStraw = false;
    private bool firstDetergent = false;
    private bool firstCup = false;

    private void OnTriggerEnter2D (Collider2D collider)
  {
      if(collider.gameObject.tag == "Fish"){

        //Code for adding to score goes here

        Destroy(collider.gameObject);

      }
      else if(collider.gameObject.tag == "Box" && firstBox == false) {

        //Code for decreasing score goes here

        Destroy(collider.gameObject);
        DisplayBoxInfo.SetActive(true);
        Time.timeScale = 0f;
        firstBox = true;

      }
      else if(collider.gameObject.tag == "Straw" && firstStraw == false) {

        //Code for decreasing score goes here

        Destroy(collider.gameObject);
        DisplayStrawInfo.SetActive(true);
        Time.timeScale = 0f;
        firstStraw = true;

      }
      else if(collider.gameObject.tag == "Detergent" && firstDetergent == false) {

        //Code for decreasing score goes here

        Destroy(collider.gameObject);
        DisplayDetergentInfo.SetActive(true);
        Time.timeScale = 0f;
        firstDetergent = true;

      }
      else if(collider.gameObject.tag == "Bottle" && firstBottle == false){

        //Code for decreasing score goes here

        Destroy(collider.gameObject);
        DisplayBottleInfo.SetActive(true);
        Time.timeScale = 0f;
        firstBottle = true;

      }
      else if(collider.gameObject.tag == "Cup" && firstCup == false){

        //Code for decreasing score goes here

        Destroy(collider.gameObject);
        DisplayBottleInfo.SetActive(true);
        Time.timeScale = 0f;
        firstCup = true;

      }
      else {

        //Code for decreasing score goes here

        Destroy(collider.gameObject);

      }

  }

}
