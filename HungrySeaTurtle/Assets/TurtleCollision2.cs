using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TurtleCollision2 : MonoBehaviour
{

	  [SerializeField] GameObject DisplayGameover;

    public void OnTriggerEnter2D (Collider2D collider)
  {
      if(collider.gameObject.tag == "Fish"){

        //Code for adding to score goes here

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

  		Destroy(collider.gameObject);

  	  }
  }

}
