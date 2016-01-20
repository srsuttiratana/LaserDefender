using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	float mousePosInBlocks;
	Vector3 paddlePos;
	public bool autoPlay = false;
	private Ball ball;
	// Use this for initialization
	void Start () {
		//paddlePos = new Vector3 (this.transform.position.x, this.transform.position.y, 0f);
		paddlePos = new Vector3 (0f, this.transform.position.y, 0f);
		ball = GameObject.FindObjectOfType<Ball> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!autoPlay) {
			MoveWithMouse ();
		} else {
			AutoPlay();
		}
	}

	void AutoPlay(){
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp(ballPos.x, 1.1f, 14.8f);
		this.transform.position = paddlePos;
	}

	void MoveWithMouse(){
		mousePosInBlocks = (Input.mousePosition.x / Screen.width * 16);
		paddlePos = new Vector3 (Mathf.Clamp(mousePosInBlocks, 1.1f, 14.8f), this.transform.position.y, 0f);
		this.transform.position = paddlePos;
	}
}
