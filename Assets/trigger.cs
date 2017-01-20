using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

	public bool right;
	public gamecontroller gc;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log(right);
		if(other.CompareTag("Ball"))
		{
			gc.score(right);
		}
	}
}
