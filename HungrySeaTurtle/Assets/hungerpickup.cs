using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hungerpickup : MonoBehaviour
{
    public float pickup;

    void update()
    {
        hungerBar.Hunger = pickup; ;
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Fish")
        {
            pickup += 30f;
            Destroy(collider.gameObject);
        }
    }
}
