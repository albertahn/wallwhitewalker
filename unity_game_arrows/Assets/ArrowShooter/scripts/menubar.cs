using UnityEngine;
using System.Collections;

public class menubar : MonoBehaviour {
	private Vector3 speed = new Vector3(0,0.5f, 0);
	public float timerValue = 100;
	public bool startTimer = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () { 
		TapSelect(); 
		if (startTimer) {
			timerValue -= Time.deltaTime;
			}
		if (timerValue <= 0) {
			Application.LoadLevel(2);
				}
	}
	
	void TapSelect() { 
		foreach (Touch touch in Input.touches) 
		{ 

			if (touch.phase == TouchPhase.Began) { 
				Ray ray = Camera.main.ScreenPointToRay(touch.position); 
				RaycastHit hit ; 
				if (Physics.Raycast (ray, out hit)) 
				{ 
					GetComponent<Rigidbody>().useGravity = true;
					GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + speed);
					//hit.transform.SendMessage("Selected"); 
					startTimer = true;
				} 
			} 
		} 
	}



}
