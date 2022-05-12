using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public Slider HealthSlider;
    public static float Health;
    public float maxHealth = 100f;
    public GameObject gameOver;

    void Start()
    {
        Health = maxHealth;
    }

    void Update()
    {
        HealthSlider.value = Health;
        if (HealthSlider.value <= 1)
        {
            gameOver.SetActive(true);
        }
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Box")
        {
            Health -= 10f;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag == "Straw")
        {
            Health -= 10f;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag == "Detergent")
        {
            Health -= 10f;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag == "Bottle")
        {
            Health -= 10f;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag == "GlassBottle")
        {
            Health -= 10f;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag == "GlassBottle2")
        {
            Health -= 10f;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag == "Cup")
        {
            Health -= 10f;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag == "Jar")
        {
            Health -= 10f;
            Destroy(collider.gameObject);

        }

        if (collider.gameObject.tag == "Can")
        {
            Health -= 10f;
            Destroy(collider.gameObject);

        }

    }
}
