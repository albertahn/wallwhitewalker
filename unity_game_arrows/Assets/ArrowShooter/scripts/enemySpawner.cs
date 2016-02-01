using UnityEngine;
using System.Collections;

public class enemySpawner : MonoBehaviour {
	public GameObject enemy; // Bullet prefeb
	//public GameObject Shell; // Shell prefeb
	public Transform EnemySpawn; // position of bullet spawn
	public int counter = 500;
	// Use this for initialization
	void Start () {
	
	}	
	// Update is called once per frame
	void Update () {
		counter--;
		if(counter <= 0){
		instanced();
			counter = 500;
		}
	}

	void instanced(){
		GameObject bullet = Instantiate(enemy,EnemySpawn.position, EnemySpawn.rotation) as GameObject;
	}
}












