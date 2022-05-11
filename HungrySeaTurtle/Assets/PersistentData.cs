using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
  public static string playerName;
  public static int playerScore = 0;
  public static int increase1 = 10;
  public static int decrease1 = 10;

  // Start is called before the first frame update
  void Start()
  {
       playerName = "";

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void SetName(string s)
 {
     playerName = s;
 }

   public static void addToScore()
  {
      playerScore += increase1;
  }

  public static void subtractScore()
  {
     playerScore -= decrease1;
  }

}
