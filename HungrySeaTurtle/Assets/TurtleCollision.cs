using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleCollision : MonoBehaviour
{

    [SerializeField] GameObject DisplayBoxInfo;
    [SerializeField] GameObject DisplayStrawInfo;
    [SerializeField] GameObject DisplayDetergentInfo;
    [SerializeField] GameObject DisplayBottleInfo;
    private bool firstHit = false;

    private void OnTriggerEnter2D (Collider2D collider)
  {
      if(collider.gameObject.tag == "Fish"){

        //Code for adding to score goes here

        Destroy(collider.gameObject);

      }
      else if(collider.gameObject.tag == "Box" && firstHit == false) {

        //Code for decreasing score goes here

        Destroy(collider.gameObject);
        DisplayBoxInfo.SetActive(true);
        Time.timeScale = 0f;
        firstHit = true;

      }
      else if(collider.gameObject.tag == "Straw" && firstHit == false) {

        //Code for decreasing score goes here

        Destroy(collider.gameObject);
        DisplayStrawInfo.SetActive(true);
        Time.timeScale = 0f;
        firstHit = true;

      }
      else if(collider.gameObject.tag == "Detergent" && firstHit == false) {

        //Code for decreasing score goes here

        Destroy(collider.gameObject);
        DisplayDetergentInfo.SetActive(true);
        Time.timeScale = 0f;
        firstHit = true;

      }
      else if(collider.gameObject.tag == "Bottle" && firstHit == false){

        //Code for decreasing score goes here

        Destroy(collider.gameObject);
        DisplayBottleInfo.SetActive(true);
        Time.timeScale = 0f;
        firstHit = true;

      } else {

        //Code for decreasing score goes here
        
        Destroy(collider.gameObject);

      }

  }

}
