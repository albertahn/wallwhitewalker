using UnityEngine;
using System.Collections;

public class arrowScripts : MonoBehaviour {
    public GameObject HumanHit;// particle when bullet hit
    public GameObject otherHit;
    public bool hited = false;
	public int Damage = 10;
    // Use this for initialization
	void Start () {
        //RayShoot();
	}
    void OnCollisionEnter(Collision colli)
    {
       
        if (!hited)
        {
            Destroy(GetComponent<Rigidbody>());
			Destroy(GetComponent<Collider>());
            hited = true;
            //GameObject.
		if (colli.gameObject.GetComponent<enemyMove>())
        {
				Destroy(this.gameObject);
				colli.gameObject.GetComponent<enemyMove>().ApplyDamageArea(Damage);
        }
        }
        else
        {

        }
        // When hit the target

      
    }
	// Update is called once per frame
	void Update () {
        if (!hited) { 
			transform.up =  Vector3.Slerp(transform.up, GetComponent<Rigidbody>().velocity.normalized,0.3f);
        }
        
	}
   
}
