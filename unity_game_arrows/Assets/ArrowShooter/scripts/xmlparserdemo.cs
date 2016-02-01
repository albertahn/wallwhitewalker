using UnityEngine;
using System.Collections;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
public class xmlparserdemo : MonoBehaviour {

	public TextAsset GameAsset;
	public GameObject textObject;
	static string Cube_Character = "";
	static string Cylinder_Character = "";
	static string Capsule_Character = "";
	static string Sphere_Character = "";
	public string lvlName = "";
	public string lvlNameA = "";
	public string lvlNameB = "";
	public string lvlNameC = "";
	public GameObject gameManager;
	public bool wonScreen = false;
	public GameObject starA;
	public GameObject starB;
	public GameObject starC;
	public GameObject starAg;
	public GameObject starBg;
	public GameObject starCg;
	public bool lostScreen = false;
	public bool mission = false;
	public int currLevel = 1;
	public int gameSC = 0;
	public int levelSC = 0;
	public int scoreCard = 0;
	private int starsDisplayValue = 0;
	List<Dictionary<string,string>> levels = new List<Dictionary<string,string>>();
	Dictionary<string,string> obj;
	public int oldscore = 0;
	void Start()
	{ //Timeline of the Level creator

		gameManager = GameObject.Find("gameManagerCNTRL").gameObject;
		GetLevel();
	}
	void Update(){


		}
	public void StarWork(){
		starsDisplayValue = gameManager.GetComponentInChildren<gameKing>().curStarScore;

		if(starsDisplayValue == 0){
			starA.active = false;
			starB.active = false;
			starC.active = false;
		}
			if(starsDisplayValue == 1){
				starAg.active = false;
				starB.active = false;
				starC.active = false;
			}
			if(starsDisplayValue == 2){
				starAg.active = false;
				starBg.active = false;
				starC.active = false;

			}
			if(starsDisplayValue == 3){
				starAg.active = false;
				starBg.active = false;
				starCg.active = false;
			}

		}
	public void GetLevel()
	{
		int clockSec = 0;
		string shotType = "";
		int shotTypeScore = 0;
		XmlDocument xmlDoc = new XmlDocument(); // xmlDoc is the new xml document.
		xmlDoc.LoadXml(GameAsset.text); // load the file.
		XmlNodeList levelsList = xmlDoc.GetElementsByTagName("level"); // array of the level nodes.
		
		foreach (XmlNode levelInfo in levelsList)
		{
			XmlNodeList levelcontent = levelInfo.ChildNodes;
			obj = new Dictionary<string,string>(); // Create a object(Dictionary) to colect the both nodes inside the level node and then put into levels[] array.
			
			foreach (XmlNode levelsItens in levelcontent) // levels itens nodes.
			{
				if(levelsItens.Name == "name")
				{
					obj.Add("name",levelsItens.InnerText); // put this in the dictionary.
				}
						
				if(levelsItens.Name == "object")
				{
					switch(levelsItens.Attributes["name"].Value)
					{
					  case "textA": obj.Add("textA",levelsItens.InnerText);break; // put this in the dictionary.
					  case "textB":obj.Add("textB",levelsItens.InnerText); break; // put this in the dictionary.
					  case "textC":obj.Add("textC",levelsItens.InnerText); break; // put this in the dictionary.
					
					}
				}
			
			}
			levels.Add(obj); // add whole obj dictionary in the levels[].


		}
		gameManager.GetComponentInChildren<gameKing>().GetCurrLevelCode ();
		currLevel = gameManager.GetComponentInChildren<gameKing>().currlevel;
		//currLevel = 1;

		levels[currLevel-1].TryGetValue("name",out lvlName);
		levels[currLevel-1].TryGetValue("textA",out lvlNameA);
		levels[currLevel-1].TryGetValue("textB",out lvlNameB);
		levels[currLevel-1].TryGetValue("textC",out lvlNameC);
//		textObject.GetComponentInChildren<UILabel> ().text = lvlName;
//		textObject.GetComponentInChildren<UILabel> ().text += "\n";
//		if (lostScreen || mission) {
//			textObject.GetComponentInChildren<UILabel> ().text += "\n";
//			textObject.GetComponentInChildren<UILabel> ().text += lvlNameA;
//			textObject.GetComponentInChildren<UILabel> ().text += "\n";
//			textObject.GetComponentInChildren<UILabel> ().text += lvlNameB;
//			textObject.GetComponentInChildren<UILabel> ().text += "\n";
//
//			textObject.GetComponentInChildren<UILabel> ().text += lvlNameC;
//			textObject.GetComponentInChildren<UILabel> ().text += "\n"; 
//				}
		switch (currLevel) {
		case 1:	oldscore = gameManager.GetComponentInChildren<gameKing>().crateOA; break;
		case 2:	oldscore = gameManager.GetComponentInChildren<gameKing>().crateOB; break;
		case 3:	oldscore = gameManager.GetComponentInChildren<gameKing>().crateOC; break;
		case 4:	oldscore = gameManager.GetComponentInChildren<gameKing>().crateOD; break;
		case 5:	oldscore = gameManager.GetComponentInChildren<gameKing>().crateOE; break;
		case 6:	oldscore = gameManager.GetComponentInChildren<gameKing>().crateOF; break;
		case 7:	oldscore = gameManager.GetComponentInChildren<gameKing>().crateOG; break;
		case 8:	oldscore = gameManager.GetComponentInChildren<gameKing>().crateOH; break;
		case 9:	oldscore = gameManager.GetComponentInChildren<gameKing>().crateOI; break;
		case 10:oldscore = gameManager.GetComponentInChildren<gameKing>().crateOJ; break;
//		case 11:oldscore = gameManager.GetComponentInChildren<gameKing>().crateOK; break;
//		case 12:oldscore = gameManager.GetComponentInChildren<gameKing>().crateOL; break;
//		case 13:oldscore = gameManager.GetComponentInChildren<gameKing>().crateOM; break;
//		case 14:oldscore = gameManager.GetComponentInChildren<gameKing>().crateON; break;
//		case 15:oldscore = gameManager.GetComponentInChildren<gameKing>().crateOO; break;
//		case 16:oldscore = gameManager.GetComponentInChildren<gameKing>().crateOP; break;
//		case 17:oldscore = gameManager.GetComponentInChildren<gameKing>().crateOQ; break;
//		case 18:oldscore = gameManager.GetComponentInChildren<gameKing>().crateOR; break;
//		case 19:oldscore = gameManager.GetComponentInChildren<gameKing>().crateOS; break;
//		case 20:oldscore = gameManager.GetComponentInChildren<gameKing>().crateOT; break;
				}
		if(wonScreen){

			gameManager.GetComponentInChildren<gameKing> ().displayVal = 0;
			gameManager.GetComponentInChildren<gameKing> ().getGameScoreValues();
			clockSec = gameManager.GetComponentInChildren<gameKing> ().clockTimer;
			shotType = gameManager.GetComponentInChildren<gameKing> ().shotOn;
			shotTypeScore = gameManager.GetComponentInChildren<gameKing> ().shotScore;
			gameSC = gameManager.GetComponentInChildren<gameKing> ().gameScore;
			levelSC = gameManager.GetComponentInChildren<gameKing> ().levelScore;
			scoreCard = gameManager.GetComponentInChildren<gameKing> ().scoreCard;
			scoreCard = gameManager.GetComponentInChildren<gameKing> ().scoreCard;
//			textObject.GetComponentInChildren<UILabel> ().text += "\n";
//			textObject.GetComponentInChildren<UILabel> ().text += "\n";
//			textObject.GetComponentInChildren<UILabel> ().text += "\n";
//			textObject.GetComponentInChildren<UILabel> ().text += "Score: "+scoreCard+"\n";
//			textObject.GetComponentInChildren<UILabel> ().text += "Timer Score: "+clockSec+"sec x 100 = "+(clockSec*100)+"\n";
//			textObject.GetComponentInChildren<UILabel> ().text += "Kill Score: "+shotType+" = "+ shotTypeScore+"\n";
//			textObject.GetComponentInChildren<UILabel> ().text += "Current Level Score: "+levelSC+"\n";
//			textObject.GetComponentInChildren<UILabel> ().text += "Previous Level Score: "+oldscore+ "\n";
//			textObject.GetComponentInChildren<UILabel> ().text += "Game Score: "+gameSC+ "\n";
			StarWork();
			}
		if(lostScreen){
			gameManager.GetComponentInChildren<gameKing>().lostRecover();
//			if(gameManager.GetComponentInChildren<gameKing>().readLostCode == 1){
//				textObject.GetComponentInChildren<UILabel> ().text += "You were too Close to the Animal, Maintain undetected Distance from next time onwards. "+"\n";
//			}
//			if(gameManager.GetComponentInChildren<gameKing>().readLostCode == 2){
//				textObject.GetComponentInChildren<UILabel> ().text += "The Target Animal went out of Boundary levels. Make sure you kill it within given space and in given time. "+"\n";
//			}
//			if(gameManager.GetComponentInChildren<gameKing>().readLostCode == 3){
//				textObject.GetComponentInChildren<UILabel> ().text += "OUT OF TIME!!!! You did not kill in given space of time."+"\n";
//			}
//			if(gameManager.GetComponentInChildren<gameKing>().readLostCode == 4){
//				textObject.GetComponentInChildren<UILabel> ().text += "You Missed and didnt shoot out in time.The Target Animal went out of Boundary levels."+"\n";
//			}if(gameManager.GetComponentInChildren<gameKing>().readLostCode == 5){
//				textObject.GetComponentInChildren<UILabel> ().text += "You were killed by this animal.Try again this time give it right shots."+"\n";
//			}
		}
	}

}
