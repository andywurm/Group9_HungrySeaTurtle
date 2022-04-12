using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canFloat : MonoBehaviour
{

    private GameObject can;
    public GameObject DecideDemo;
    bool up = true;

    // Start is called before the first frame update
    void Start()
    {
      if(can == null){
        can = GameObject.Find("can");
      }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      floatEffect();
    }

    void floatEffect(){

      var temp = transform.position;

      if(up == true)
      {
          temp.y += 0.01f;
          transform.position=temp;

          if(transform.position.y >= .1f)
          {
              up = false;
          }
      }
      if(up == false)
      {
          temp.y -= 0.01f;
          transform.position=temp;

          if(transform.position.y<=-1f)
          {
              up = true;
          }
      }
    }

    private void OnTriggerEnter2D (Collider2D collider)
  {
    DecideDemo.SetActive(true);
  }

}
