using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	bool isLeftArrowKeyPressed = false;
	bool isRightArrowKeyPressed = false;
	bool isUpArrowKeyPressed = false;
	bool isDownArrowKeyPressed = false;

	public float speed;
	// Use this for initialization
	void Start () {

	}

	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.position = new Vector3(-2, 0, this.transform.position.z);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.position = new Vector3(2, 0, this.transform.position.z);
		}
		if(Input.GetKey (KeyCode.DownArrow)) {
			this.transform.position = new Vector3(0, 0, this.transform.position.z);
		}
	}









































	// Update is called once per frame
//	void Update () {
//		if (Input.GetKey(KeyCode.LeftArrow))
//		{
//			isLeftArrowKeyPressed = true;
////			transform.position += Vector3.left * speed * Time.deltaTime;
//		}
//		if (Input.GetKey(KeyCode.RightArrow))
//		{
//			isRightArrowKeyPressed = true;
////			transform.position += Vector3.right * speed * Time.deltaTime;
//		}
//		if (Input.GetKey(KeyCode.UpArrow))
//		{
//			isUpArrowKeyPressed = true;
////			transform.position += Vector3.up * speed * Time.deltaTime;
//		}
//
//		if (Input.GetKey(KeyCode.DownArrow))
//		{
//			isDownArrowKeyPressed = true;
//			//			transform.position += Vector3.up * speed * Time.deltaTime;
//		}
//		
//
//		// Check if the left arrow key is pressed
//		if (isLeftArrowKeyPressed) {
//			// move left 
//			print ("Left Key pressed!");
//			this.transform.position = new Vector3 (-5, 0, 0);
//		}
//		// Check if right arrow key is pressed
//		if (isRightArrowKeyPressed) {
//			// move right
//			print ("Right Key pressed!");
//			this.transform.position = new Vector3 (5,0,0);
//		}
//		// Check if up arrow key is pressed
//		if (isUpArrowKeyPressed) {
//			// move up
//			print("Up Key pressed!");
//			this.transform.position = new Vector3(0,5,0);
//		}
//
//
//		if (isDownArrowKeyPressed) {
//			// move down
//			print ("Down Key pressed!");
//			this.transform.position = new Vector3 (0, 0, 0);
//
//		}
//
//		isLeftArrowKeyPressed = false;
//		isRightArrowKeyPressed = false;
//		isUpArrowKeyPressed = false;
//		isDownArrowKeyPressed = false;

	}

















	//		int myIntegerVariable = 0;
	//		myIntegerVariable = 10;
	//
	//		bool israsheedcool = true;
	//		bool heHasADate;
	//
	//		if (TheLeftArrowKeyIsPressed) {
	//			// Move left
	//
	//		}






















	
//	void Update ()
//	{
//		if (Input.GetKey(KeyCode.LeftArrow))
//		{
//			transform.position += Vector3.left * speed * Time.deltaTime;
//		}
//		if (Input.GetKey(KeyCode.RightArrow))
//		{
//			transform.position += Vector3.right * speed * Time.deltaTime;
//		}
//		if (Input.GetKey(KeyCode.UpArrow))
//		{
//			transform.position += Vector3.up * speed * Time.deltaTime;
//		}
//		if (Input.GetKey(KeyCode.DownArrow))
//		{
//			transform.position += Vector3.down * speed * Time.deltaTime;
//		}
//	}


