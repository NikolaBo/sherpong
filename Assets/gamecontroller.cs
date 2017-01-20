using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gamecontroller : MonoBehaviour {
	
	public Text rightText;
	public Text leftText;
	public int rightScore = 0;
	public int leftScore = 0;
	public ball b;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void score (bool right)
	{
		b.reset();
		if (right)
		{
			leftScore++;
			leftText.text = leftScore.ToString();
		}
		if (!right)
		{
			rightScore++;
			rightText.text = rightScore.ToString();
		}
	}
}
