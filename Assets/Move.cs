using UnityEngine;
using System.Collections;
public class Move : MonoBehaviour {
	public float speed = 30;

	void FixedUpdate ()
	{
		float v = Input.GetAxisRaw("Horizontal");
		GetComponent<Rigidbody2D>().velocity += new Vector2(v, 0) * speed;
	}
}
