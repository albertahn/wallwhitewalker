using UnityEngine;
using System.Collections;

public class loader : MonoBehaviour {
	public bool starterBox = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (starterBox) {
			Application.LoadLevel(1);
				}
	}
}
