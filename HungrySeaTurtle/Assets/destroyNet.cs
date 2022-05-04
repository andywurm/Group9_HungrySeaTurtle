using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyNet : MonoBehaviour
{
    public void OnTriggerEnter2D (Collider2D collider){
		if(collider.gameObject.tag == "theNet")
			Destroy(collider.gameObject);
	}
}
