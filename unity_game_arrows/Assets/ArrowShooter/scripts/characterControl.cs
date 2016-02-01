using UnityEngine;
using System.Collections;

public class characterControl : MonoBehaviour {
	public float dragValue = 0;
	private float offset = 10;
	public GameObject arrowThread;
	public GameObject heroHand;
	public GameObject firerig;
	public GameObject forceFeed;
	public GameObject characterBody;
	public float rotateValue = 0;
	private bool shootReady = false;
	public GUIText guiLayer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		rotateValue = this.gameObject.GetComponent<touchRotate> ().rotateAsserted;

		if (rotateValue >= -0.7 && rotateValue <= 0.7) {
			dragValue = this.gameObject.GetComponent<touchRotate> ().forceAsserted;	
			characterBody.gameObject.transform.localScale = new Vector3(0.2146157f, 0.4759961f ,0.2332218f);		
			characterBody.gameObject.transform.position = new Vector3(-4.5f,characterBody.gameObject.transform.position.y,characterBody.gameObject.transform.position.z);
			this.gameObject.transform.position = new Vector3(-4.6f,this.gameObject.transform.position.y,this.gameObject.transform.position.z);	
		} else {
			dragValue = -(this.gameObject.GetComponent<touchRotate> ().forceAsserted);	
			characterBody.gameObject.transform.localScale = new Vector3(-0.2146157f, 0.4759961f ,0.2332218f);
			characterBody.gameObject.transform.position = new Vector3(-4.9f,characterBody.gameObject.transform.position.y,characterBody.gameObject.transform.position.z);
			this.gameObject.transform.position = new Vector3(-4.8f,this.gameObject.transform.position.y,this.gameObject.transform.position.z);	
		}
		guiLayer.GetComponent<GUIText>().text = ""+ (dragValue);
		if (dragValue >= 3) {
				
				if(dragValue <= 10){
				heroHand.gameObject.transform.localScale = new Vector3(7-(dragValue/2), 4 ,4);
				forceFeed.gameObject.transform.localScale = new Vector3((dragValue/5), 2.066724f ,2.066724f);
				arrowThread.gameObject.transform.localScale = new Vector3((dragValue/3), 3 ,3);
			    firerig.gameObject.GetComponent<gunHandlerEnem> ().Force = (int)(dragValue) * 300;
				shootReady = true;
				}
				} else if(dragValue == 0) {
			if(shootReady == true){
			firerig.gameObject.GetComponent<gunHandlerEnem> ().Shoot();
				shootReady = false;
			}
			heroHand.gameObject.transform.localScale = new Vector3(4.6f, 4, 4);
			arrowThread.gameObject.transform.localScale = new Vector3(1.5f, 3 ,3);
			forceFeed.gameObject.transform.localScale = new Vector3(0.5f, 1 ,1);
			firerig.gameObject.GetComponent<gunHandlerEnem> ().Force = 1500;
				}


	}
}
