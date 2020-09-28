using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bladeMovement : MonoBehaviour {

	public float speed = 5f;
	public float constraintZ = 10f;
	private Rigidbody rb;
	public float horiz;
	public GameObject blade;
	public bool mobileInput = false;


	private void Start()
    {
		rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate () {
		if (!mobileInput)
		{
			horiz = Input.GetAxis("Horizontal") * speed;

		}
		horiz = Mathf.Clamp(horiz, -5f,5f);
		rb.velocity = new Vector3(0, 0, horiz * speed);
		BladeRotator();
	}
	void BladeRotator()
    {
		blade.transform.Rotate(0,0,speed/2f,Space.Self);
    }

	public void leftOn()
    {
		horiz = -4f;
	}
	public void leftOff()
	{
		horiz = 0;
	}
	public void rightOn()
    {
		horiz = 4f;
	}
	public void rightOff()
	{
		horiz = 0;
	}

}
