using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hungerbar : MonoBehaviour
{
    public Slider HungerSlider;
    public static float Hunger;
    float maxHunger = 100f;
    public GameObject gameOver;

    void Start()
    {
        Hunger = maxHunger;
    }


    void Update()
    {
        
        HungerSlider.value = Hunger;

        Hunger -= 1f * Time.deltaTime;

        if (HungerSlider.value <= 1)
        {
            gameOver.SetActive(true);
        }


        if (Input.GetKey(KeyCode.UpArrow))
        {
            Hunger -= 1f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Hunger -= 1f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Hunger -= 1f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Hunger -= 1f * Time.deltaTime;
        }
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Box")
        {
            Hunger -= 10f;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag == "Straw")
        {
            Hunger -= 10f;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag == "Detergent")
        {
            Hunger -= 10f;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag == "Bottle")
        {
            Hunger -= 10f;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag == "GlassBottle")
        {
            Hunger -= 10f;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag == "GlassBottle2")
        {
            Hunger -= 10f;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag == "Cup")
        {
            Hunger -= 10f;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag == "Jar")
        {
            Hunger -= 10f;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag == "Can")
        {
            Hunger -= 10f;
            Destroy(collider.gameObject);

        }

    }
}
