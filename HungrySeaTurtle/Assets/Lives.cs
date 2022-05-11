using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
  Text life;

  // Start is called before the first frame update
  void Start()
  {
    life = GetComponent<Text>();
  }

  // Update is called once per frame
  void Update()
  {
    life.text = "SCORE: " + PersistentData.playerScore;
  }
}
