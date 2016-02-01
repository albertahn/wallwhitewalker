using UnityEngine;
using System.Collections;

public class dragonScript : MonoBehaviour {
	public Vector3 speedA = new Vector3(-0.1f, 0, 0);
	public Vector3 speedB = new Vector3(0.1f, 0, 0);
	public int counter = 1000;
	private int variab = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		counter -= (int)(Time.smoothDeltaTime*100);
//		Debug.Log (Time.smoothDeltaTime*100);
		if(counter <= 0){
			counter = 1000;
			if(variab == 0){
				variab = 1;
			}
			else{
				variab = 0;
			}
		}
		instanced(variab);
	}
	void instanced(int varia){
		if(varia == 0)
		GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + speedB * Time.deltaTime);
		if(varia == 1)
		GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + speedA * Time.deltaTime);
	}
}
