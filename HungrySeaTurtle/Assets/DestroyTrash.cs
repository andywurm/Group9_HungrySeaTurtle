using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrash : MonoBehaviour
{
	[SerializeField] Rigidbody2D myTrash;
	float yMax = -4.3f;
    // Start is called before the first frame update
    void Start()
    {
        myTrash = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < yMax)
			Destroy(gameObject);
    }
}
