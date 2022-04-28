using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hungerPickup : MonoBehaviour
{ 

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Fish")
        {
            hungerBar.Hunger += 20f;
            Destroy(collider.gameObject);

        }
    }
}
