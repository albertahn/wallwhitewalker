using UnityEngine;
using System.Collections;

public class levelController : MonoBehaviour {
	public int EmeniesTotal = 0;
	public int EmeniesNormal = 0;
	public int EmeniesShooting = 0;
	public int EmeniesFlying = 0;
	public bool dragonEntry = false;
	public int LevelNum = 0;
	public int LevelScore = 0;
	public int LevelLifeBar = 10;
	public int enemySafe = 0;
 	// Use this for initialization
	void Awake(){
		EmeniesTotal = EmeniesNormal + EmeniesShooting + EmeniesFlying;
		}
	void Start () {

		}
	public void enemyCounter(){

		}
	// Update is called once per frame
	void Update () {

		}

}
