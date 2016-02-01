using UnityEngine;
using System.Collections;

public class gunHandlerEnem : MonoBehaviour {
	public GameObject Bullets; // Bullet prefeb
	//public GameObject Shell; // Shell prefeb
	public Transform BulletSpawn; // position of bullet spawn
	//public Transform ShellSpawn; // position of shell spawn
	public float fireRate = 0.2f; // rate of fire 
	public bool shotFired = false;
	public AudioClip SoundGunFire;
	public AudioClip SoundBoltEnd;
	public AudioClip SoundBoltStart;
	public int Force = 10;
	public GameObject enem;
	private bool boltout;
	private int indexcamera;
	private float timefire = 0;
	private int gunState = 0;
	private int ammoin = 1;
	private float camsensitivity = 30.0f;
	private float zoomedcam = 3.0f;
	public int counter = 200;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
      
			//counter--;
			//if(counter <= 0){
			//	Shoot();
				
			//}
		switch(gunState){
		case 0:
			if(ammoin<=0){
				if(indexcamera != 1){
					//animation.CrossFade("Bolt");
					gunState = 2;
					if(SoundBoltStart){
						AudioSource.PlayClipAtPoint(SoundBoltStart,this.transform.position);
					}
				}
			}
			
			break;
		case 1:
//			if(animation["Shoot"].time >= animation["Shoot"].length*0.8f){
				gunState = 0;
	//		}
			break;
		case 2:

		
			//if (animation["Bolt"].time >= animation["Bolt"].length*0.8f){
				gunState = 0;
				ammoin = 1;
				
			//	animation.CrossFade("Idle");
				if(SoundBoltEnd){
					AudioSource.PlayClipAtPoint(SoundBoltEnd,this.transform.position);
				}
			//}
			break;
		}
	}

	public void Shoot(){
		shotFired = true;
        counter = 200;
		//Debug.Log("FIRE ME");
		if(timefire + fireRate < Time.time){
			if(gunState==0){
				if(ammoin>0){
					
					if(SoundGunFire){
						AudioSource.PlayClipAtPoint(SoundGunFire,this.transform.position);
					}
					if(Bullets && BulletSpawn){
						GameObject bullet = Instantiate(Bullets,BulletSpawn.position, BulletSpawn.rotation) as GameObject;
						//bullet.GetComponentInChildren<bulletScripts>().SetUp(enem);
						bullet.GetComponent<Rigidbody>().AddForce(transform.up*Force);
						
					}
									
					boltout = false;
					//animation.Play("Shoot");
					timefire = Time.time;
					gunState = 1;
					ammoin = 1;
					
				}
			}
		}
	}

}
