using UnityEngine;
using System.Collections;

public class enemyMove : MonoBehaviour {
	private Vector3 speed = new Vector3(-0.5f, 0, 0);
	public GameObject fallSprite;
	public GameObject hitSprite;
	// Use this for initialization
	void Start () {
	
	}	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + speed * Time.deltaTime);
	}
	public void ApplyDamageArea(int damage){
		Destroy (this.gameObject);
		GameObject bullet = Instantiate(fallSprite,this.gameObject.transform.position, this.gameObject.transform.rotation) as GameObject;
	}
	public void ApplyAggresiveSoldier(){
		Destroy (this.gameObject);
		GameObject bullet = Instantiate(hitSprite,this.gameObject.transform.position, this.gameObject.transform.rotation) as GameObject;
	}
}
