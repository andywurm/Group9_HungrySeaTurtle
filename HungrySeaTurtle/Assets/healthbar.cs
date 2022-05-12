using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    public Slider HealthSlider;
    public static float Health;
    float maxHealth = 100f;

    void Start()
    {
        Health = maxHealth;
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
