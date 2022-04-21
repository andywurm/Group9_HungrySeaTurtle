using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : MonoBehaviour
{
	[SerializeField] int speed;
	[SerializeField] Rigidbody2D myfish; 
    // Start is called before the first frame update
    void Start()
    {
        
        myfish =this.GetComponent<Rigidbody2D>();
		speed = 5;
		myfish.velocity = new Vector2 (-speed, 0);
    }

    // Update is called once per frame

	double xMax = -16;

    void Update()
    {
       if(transform.position.x < xMax)
			Destroy(this.gameObject);
    }
}
