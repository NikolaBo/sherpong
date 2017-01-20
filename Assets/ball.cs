using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	private Rigidbody2D rb;
	public float velocity;
	public float[] angles;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		reset();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void reset()
	{
		transform.position = Vector3.zero;
		Quaternion rot = transform.rotation;
		int rand = Mathf.RoundToInt(Random.Range(0,angles.Length-1));
		rot = Quaternion.Euler(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y, angles[rand]);
		transform.rotation = rot;
		
		rb.velocity = transform.up*velocity;
	}
}
