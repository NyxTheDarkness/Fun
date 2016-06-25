using UnityEngine;
using System.Collections;
public class Move : MonoBehaviour {
	public float speed = 30;
	float v;

	void Update()
	{
		v = Input.GetAxisRaw("Horizontal");
	}

	void FixedUpdate ()
	{
		GetComponent<Rigidbody2D>().velocity += new Vector2(v, 0) * speed;
	}
}
