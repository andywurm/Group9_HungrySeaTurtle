using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleCollision : MonoBehaviour
{

    private void OnTriggerEnter2D (Collider2D collider)
  {
      if(collider.gameObject.tag == "Fish"){
        //Code for adding to score goes here
        Debug.Log("Fish hit");
        Destroy(collider.gameObject);
      }else {
        //Code for decreasing score goes here
        Debug.Log("Trash hit");
        Destroy(collider.gameObject);
      }

  }

}
