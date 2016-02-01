using UnityEngine;
using System.Collections;

public class pullarrow : MonoBehaviour {

	public float dragValue = 0;
	private float offset = 10;

	private bool shootReady; 
	public GameObject firerig;


	public float rotateValue = 0;
	
	public GameObject guiLayer;
	// Use this for initialization
	void Start () {
		shootReady = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		rotateValue = this.gameObject.GetComponent<touchRotate> ().rotateAsserted;
		
		if (rotateValue >= -0.7 && rotateValue <= 0.7) 
		{
			dragValue = this.gameObject.GetComponent<touchRotate> ().forceAsserted;	

		} else {
			dragValue = -(this.gameObject.GetComponent<touchRotate> ().forceAsserted);	
	}
		guiLayer.GetComponent<UILabel>().text = ""+ (dragValue);
		if (dragValue >= 3) {
			
			if(dragValue <= 10){



				firerig.gameObject.GetComponent<gunHandlerEnem> ().Force = (int)(dragValue) * 100;
				shootReady = true;

				Debug.Log("shotbool: "+shootReady);

			}
		} else if(dragValue == 0) {
			if(shootReady == true){
				firerig.gameObject.GetComponent<gunHandlerEnem> ().Shoot();
				shootReady = false;
			}


			firerig.gameObject.GetComponent<gunHandlerEnem> ().Force = 10;
		}
		
		
	}
}
