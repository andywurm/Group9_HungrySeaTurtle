using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hungerBar : MonoBehaviour
{
    public Slider HungerSlider;
    public static float Hunger;
    float maxHunger = 100f;

    void Start()
    {
        Hunger = maxHunger;
    }

  
    void Update()
    {
       // Debug.Log(Hunger);
        HungerSlider.value = Hunger;

        Hunger -= 1f * Time.deltaTime;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Hunger -= 4f * Time.deltaTime;
        }

    }
}
