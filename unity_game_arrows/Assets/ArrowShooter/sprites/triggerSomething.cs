using UnityEngine;
using System.Collections;

public class triggerSomething : MonoBehaviour {
	private Vector3 speed = new Vector3(0.8f, 0, 0);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other) {
		GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + speed);
		other.gameObject.GetComponent<enemyMove>().ApplyAggresiveSoldier();
	}
}
