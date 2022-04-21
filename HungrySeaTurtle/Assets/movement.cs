using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	[SerializeField] Rigidbody2D rigid;
	[SerializeField] float movements;
	[SerializeField] float movement2;
	[SerializeField] int speed;
	[SerializeField] bool isFacingRight = true;
    // Start is called before the first frame update
    void Start()
    {
		if (rigid == null)
            rigid = GetComponent<Rigidbody2D>();
		speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        movements = Input.GetAxis("Horizontal");
		movement2 = Input.GetAxis("Vertical");
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -14f, 8f), Mathf.Clamp(transform.position.y, -5f, 5f),
		transform.position.z);

    }
	 void FixedUpdate(){
		rigid.velocity = new Vector2(movements * speed, movement2 * speed);
		if (movements < 0 && isFacingRight || movements > 0 && !isFacingRight)
            Flip();
	 }
	 void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }

}
