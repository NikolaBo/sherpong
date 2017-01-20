using UnityEngine;
using System.Collections;

public class paddle : MonoBehaviour {

	private Rigidbody2D rb;
	public Vector3 upVector;
	public Vector3 downVector;
	public KeyCode up;
	public KeyCode down;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(up))
		{
			rb.AddForce(upVector);
		}
		else if (Input.GetKey(down))
		{
			rb.AddForce(downVector);
		}
		else 
		{
			rb.AddForce(Vector3.zero);
		}
	}
}
