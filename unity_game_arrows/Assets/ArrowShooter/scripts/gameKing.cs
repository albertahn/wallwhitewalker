using UnityEngine;
using System.Collections;

public class gameKing : MonoBehaviour {
	public bool mobilePlatform = false;
	public bool developerMode = false;
	public bool cleanScore = false;
	public static int levelNextStore = 1;//made for the loading screen fix
	public static int gameLevelStore = 6;
	public static string shotOnStore = "";
	public static int clockTimerStore = 0;
	public static int shotScoreStore = 0;
	public static int levelScoreStore = 0;
	public static int gameScoreStore = 0;
	public static int scoreCardStore = 0;
	public static int starsTotalStore = 0;
	public static int readLostCodeStore = 0;
	public int readLostCode = 0;
	public int starsTotal = 3;
	public int curStarScore = 0;
	public int displayVal = 0;
	//public static string levelNamed = "";
	public int levelNext = 1;
	public bool improved = true;
	public int gameLevel = 0;
	public int crateA = 0;
	public int crateB = 0;
	public int crateC = 0;
	public int crateD = 0;
	public int crateE = 0;
	public int crateF = 0;
	public int crateG = 0;
	public int crateH = 0;
	public int crateI = 0;
	public int crateJ = 0;
//	public int crateK = 0;
//	public int crateL = 0;
//	public int crateM = 0;
//	public int crateN = 0;
//	public int crateO = 0;
//	public int crateP = 0;
//	public int crateQ = 0;
//	public int crateR = 0;
//	public int crateS = 0;
//	public int crateT = 0;
	public int crateOA = 0;
	public int crateOB = 0;
	public int crateOC = 0;
	public int crateOD = 0;
	public int crateOE = 0;
	public int crateOF = 0;
	public int crateOG = 0;
	public int crateOH = 0;
	public int crateOI = 0;
	public int crateOJ = 0;
//	public int crateOK = 0;
//	public int crateOL = 0;
//	public int crateOM = 0;
//	public int crateON = 0;
//	public int crateOO = 0;
//	public int crateOP = 0;
//	public int crateOQ = 0;
//	public int crateOR = 0;
//	public int crateOS = 0;
//	public int crateOT = 0;
	public int star_A = 0;
	public int star_B = 0;
	public int star_C = 0;
	public int star_D = 0;
	public int star_E = 0;
	public int star_F = 0;
	public int star_G = 0;
	public int star_H = 0;
	public int star_I = 0;
	public int star_J = 0;
//	public int star_K = 0;
//	public int star_L = 0;
//	public int star_M = 0;
//	public int star_N = 0;
//	public int star_O = 0;
//	public int star_P = 0;
//	public int star_Q = 0;
//	public int star_R = 0;
//	public int star_S = 0;
//	public int star_T = 0;

	public int currlevel = 0;
	public int levelScore = 0;
	public int gameScore = 0;
	public int scoreHolder = 0;
	public int tracksUnlocked = 0;
	public int clockTimer = 0;
	public string shotOn = "";
	public int shotScore = 0;
	public int scoreCard = 0;

	// Use this for initialization
	void Start () {
		//Debug.Log (levelNext);
		currlevel = gameLevelStore - 7;
	}
	void Awake(){
		if(developerMode){
			programmersKey();
		}
		if(cleanScore){
			cleanUp ();
		}
		//cleanUp ();//start fresh no score bound
		//programmersKey();//opens all levels for testing
		//Get Stored Scores
		//Get Full Scores
		int gameScoreOld = PlayerPrefs.GetInt("Player Score");
		//int gamecars = PlayerPrefs.GetInt("CarsUnLocked");
		//Get Levels Unlocked
		int gamelevels = PlayerPrefs.GetInt("TracksUnLocked");
		//Get Level Scores
		int gamelevelA = PlayerPrefs.GetInt("lvlA");
		int gamelevelB = PlayerPrefs.GetInt("lvlB");
		int gamelevelC = PlayerPrefs.GetInt("lvlC");
		int gamelevelD = PlayerPrefs.GetInt("lvlD");
		int gamelevelE = PlayerPrefs.GetInt("lvlE");
		int gamelevelF = PlayerPrefs.GetInt("lvlF");
		int gamelevelG = PlayerPrefs.GetInt("lvlG");
		int gamelevelH = PlayerPrefs.GetInt("lvlH");
		int gamelevelI = PlayerPrefs.GetInt("lvlI");
		int gamelevelJ = PlayerPrefs.GetInt("lvlJ");
//		int gamelevelK = PlayerPrefs.GetInt("lvlK");
//		int gamelevelL = PlayerPrefs.GetInt("lvlL");
//		int gamelevelM = PlayerPrefs.GetInt("lvlM");
//		int gamelevelN = PlayerPrefs.GetInt("lvlN");
//		int gamelevelO = PlayerPrefs.GetInt("lvlO");
//		int gamelevelP = PlayerPrefs.GetInt("lvlP");
//		int gamelevelQ = PlayerPrefs.GetInt("lvlQ");
//		int gamelevelR = PlayerPrefs.GetInt("lvlR");
//		int gamelevelS = PlayerPrefs.GetInt("lvlS");
//		int gamelevelT = PlayerPrefs.GetInt("lvlT");

		star_A = PlayerPrefs.GetInt("stA");
		star_B = PlayerPrefs.GetInt("stB");
		star_C = PlayerPrefs.GetInt("stC");
		star_D = PlayerPrefs.GetInt("stD");
		star_E = PlayerPrefs.GetInt("stE");
		star_F = PlayerPrefs.GetInt("stF");
		star_G = PlayerPrefs.GetInt("stG");
		star_H = PlayerPrefs.GetInt("stH");
		star_I = PlayerPrefs.GetInt("stI");
		star_J = PlayerPrefs.GetInt("stJ");
//		star_K = PlayerPrefs.GetInt("stK");
//		star_L = PlayerPrefs.GetInt("stL");
//		star_M = PlayerPrefs.GetInt("stM");
//		star_N = PlayerPrefs.GetInt("stN");
//		star_O = PlayerPrefs.GetInt("stO");
//		star_P = PlayerPrefs.GetInt("stP");
//		star_Q = PlayerPrefs.GetInt("stQ");
//		star_R = PlayerPrefs.GetInt("stR");
//		star_S = PlayerPrefs.GetInt("stS");
//		star_T = PlayerPrefs.GetInt("stT");


		if(gamelevels == 0)gamelevels = 1;
		if(gamelevelA == 0)gamelevelA = 0;
		if(gamelevelB == 0)gamelevelB = 0;
		if(gamelevelC == 0)gamelevelC = 0;
		if(gamelevelD == 0)gamelevelD = 0;
		if(gamelevelE == 0)gamelevelE = 0;
		if(gamelevelF == 0)gamelevelF = 0;
		if(gamelevelG == 0)gamelevelG = 0;
		if(gamelevelH == 0)gamelevelH = 0;
		if(gamelevelI == 0)gamelevelI = 0;
		if(gamelevelJ == 0)gamelevelJ = 0;
//		if(gamelevelK == 0)gamelevelK = 0;
//		if(gamelevelL == 0)gamelevelL = 0;
//		if(gamelevelM == 0)gamelevelM = 0;
//		if(gamelevelN == 0)gamelevelN = 0;
//		if(gamelevelO == 0)gamelevelO = 0;
//		if(gamelevelP == 0)gamelevelO = 0;
//		if(gamelevelQ == 0)gamelevelO = 0;
//		if(gamelevelR == 0)gamelevelO = 0;
//		if(gamelevelS == 0)gamelevelO = 0;
//		if(gamelevelT == 0)gamelevelO = 0;
		//carsUnlocked = gamecars;
		tracksUnlocked = gamelevels;
		crateA = gamelevelA;
		crateB = gamelevelB;
		crateC = gamelevelC;
		crateD = gamelevelD;
		crateE = gamelevelE;
		crateF = gamelevelF;
		crateG = gamelevelG;
		crateH = gamelevelH;
		crateI = gamelevelI;
		crateJ = gamelevelJ;
//		crateK = gamelevelK;
//		crateL = gamelevelL;
//		crateM = gamelevelM;
//		crateN = gamelevelN;
//		crateO = gamelevelO;
//		crateP = gamelevelP;
//		crateQ = gamelevelQ;
//		crateR = gamelevelR;
//		crateS = gamelevelS;
//		crateT = gamelevelT;
		gameScore = crateA+crateB+crateC+crateD+crateE+crateF+crateG+crateH+crateI+crateJ;
			//+crateK+crateL+crateM+crateN+crateO;
		//Debug.Log(levelScoree);
	}
	// Update is called once per frame
	public void gelLevelsOpened(){
		if(tracksUnlocked <currlevel+1){
			tracksUnlocked = PlayerPrefs.GetInt("TracksUnLocked");
		}

	}
	public void oopsYouLost(){
		readLostCodeStore = readLostCode;
		}
	public void lostRecover(){
		readLostCode = readLostCodeStore;
		}
	public void saveValues(){
		Debug.Log("Save Progress");
		switch(currlevel)
		{
		case 1: curStarScore = starsTotal; crateOA = crateA; if(crateA < scoreHolder){crateA = scoreHolder; star_A = starsTotal;} break;
		case 2:	curStarScore = starsTotal; crateOB = crateB; if(crateB < scoreHolder){ crateB = scoreHolder; star_B = starsTotal;} break;
		case 3:	curStarScore = starsTotal; crateOC = crateC; if(crateC < scoreHolder){ crateC = scoreHolder; star_C = starsTotal;} break;
		case 4:	curStarScore = starsTotal; crateOD = crateD; if(crateD < scoreHolder){crateD = scoreHolder; star_D = starsTotal;} break;
		case 5:	curStarScore = starsTotal; crateOE = crateE; if(crateE < scoreHolder){crateE = scoreHolder; star_E = starsTotal;} break;
		case 6:	curStarScore = starsTotal; crateOF = crateF;  if(crateF < scoreHolder){crateF = scoreHolder; star_F = starsTotal;} break;
		case 7:	curStarScore = starsTotal; crateOG = crateG; if(crateG < scoreHolder){ crateG = scoreHolder; star_G = starsTotal;} break;
		case 8:	curStarScore = starsTotal; crateOH = crateH; if(crateH < scoreHolder){crateH = scoreHolder; star_H = starsTotal;} break;
		case 9:	curStarScore = starsTotal; crateOI = crateI; if(crateI < scoreHolder){crateI = scoreHolder; star_I = starsTotal;} break;
		case 10: curStarScore = starsTotal; crateOJ = crateJ; if(crateJ < scoreHolder){crateJ = scoreHolder; star_J = starsTotal;} break;
//		case 11: curStarScore = starsTotal; crateOK = crateK; if(crateK < scoreHolder){ crateK = scoreHolder; star_K = starsTotal;} break;
//		case 12: curStarScore = starsTotal; crateOL = crateL; if(crateL < scoreHolder){ crateL = scoreHolder; star_L = starsTotal;} break;
//		case 13: curStarScore = starsTotal; crateOM = crateM;  if(crateM < scoreHolder){crateM = scoreHolder; star_M = starsTotal;} break;
//		case 14: curStarScore = starsTotal; crateON = crateN;  if(crateN < scoreHolder){crateN = scoreHolder; star_N = starsTotal;} break;
//		case 15: curStarScore = starsTotal; crateOO = crateO;  if(crateO < scoreHolder){crateO = scoreHolder; star_O = starsTotal;} break;
//		case 16: curStarScore = starsTotal; crateOP = crateP;  if(crateP < scoreHolder){crateP = scoreHolder; star_P = starsTotal;} break;
//		case 17: curStarScore = starsTotal; crateOQ = crateQ; if(crateQ < scoreHolder){ crateQ = scoreHolder; star_Q = starsTotal;} break;
//		case 18: curStarScore = starsTotal; crateOR = crateR; if(crateR < scoreHolder){ crateR = scoreHolder; star_R = starsTotal;} break;
//		case 19: curStarScore = starsTotal; crateOS = crateS; if(crateS < scoreHolder){ crateS = scoreHolder; star_S = starsTotal;} break;
//		case 20: curStarScore = starsTotal; crateOT = crateT; if(crateT < scoreHolder){ crateT = scoreHolder; star_T = starsTotal;} break;
			
		}
		//PlayerPrefs.SetInt("CarsUnLocked", carsUnlocked);
		if(tracksUnlocked <currlevel+1){
		PlayerPrefs.SetInt("TracksUnLocked", currlevel+1);
		}
		PlayerPrefs.SetInt("lvlA", crateA);
		PlayerPrefs.SetInt("lvlB", crateB);
		PlayerPrefs.SetInt("lvlC", crateC);
		PlayerPrefs.SetInt("lvlD", crateD);
		PlayerPrefs.SetInt("lvlE", crateE);
		PlayerPrefs.SetInt("lvlF", crateF);
		PlayerPrefs.SetInt("lvlG", crateG);
		PlayerPrefs.SetInt("lvlH", crateH);
		PlayerPrefs.SetInt("lvlI", crateI);
		PlayerPrefs.SetInt("lvlJ", crateJ);
//		PlayerPrefs.SetInt("lvlK", crateK);
//		PlayerPrefs.SetInt("lvlL", crateL);
//		PlayerPrefs.SetInt("lvlM", crateM);
//		PlayerPrefs.SetInt("lvlN", crateN);
//		PlayerPrefs.SetInt("lvlO", crateO);
//		PlayerPrefs.SetInt("lvlP", crateP);
//		PlayerPrefs.SetInt("lvlQ", crateQ);
//		PlayerPrefs.SetInt("lvlR", crateR);
//		PlayerPrefs.SetInt("lvlS", crateS);
//		PlayerPrefs.SetInt("lvlT", crateT);

		PlayerPrefs.SetInt("stA", star_A);
		PlayerPrefs.SetInt("stB", star_B);
		PlayerPrefs.SetInt("stC", star_C);
		PlayerPrefs.SetInt("stD", star_D);
		PlayerPrefs.SetInt("stE", star_E);
		PlayerPrefs.SetInt("stF", star_F);
		PlayerPrefs.SetInt("stG", star_G);
		PlayerPrefs.SetInt("stH", star_H);
		PlayerPrefs.SetInt("stI", star_I);
		PlayerPrefs.SetInt("stJ", star_J);
//		PlayerPrefs.SetInt("stK", star_K);
//		PlayerPrefs.SetInt("stL", star_L);
//		PlayerPrefs.SetInt("stM", star_M);
//		PlayerPrefs.SetInt("stN", star_N);
//		PlayerPrefs.SetInt("stO", star_O);
//		PlayerPrefs.SetInt("stP", star_P);
//		PlayerPrefs.SetInt("stQ", star_Q);
//		PlayerPrefs.SetInt("stR", star_R);
//		PlayerPrefs.SetInt("stS", star_S);
//		PlayerPrefs.SetInt("stT", star_T);



		gameScore = crateA + crateB + crateC + crateD + crateE + crateF + crateG + crateH + crateI + crateJ;
			//crateK+crateL+crateM+crateN+crateO+crateP+crateQ+crateR+crateS+crateT;
		PlayerPrefs.SetInt("Player Score", gameScore);
	}
	public void cleanUp(){
		PlayerPrefs.SetInt("TracksUnLocked", 0);
		PlayerPrefs.SetInt("TracksUnLocked", currlevel+1);
	PlayerPrefs.SetInt("lvlA", 0);
	PlayerPrefs.SetInt("lvlB", 0);
	PlayerPrefs.SetInt("lvlC", 0);
	PlayerPrefs.SetInt("lvlD", 0);
	PlayerPrefs.SetInt("lvlE", 0);
	PlayerPrefs.SetInt("lvlF", 0);
	PlayerPrefs.SetInt("lvlG", 0);
	PlayerPrefs.SetInt("lvlH", 0);
	PlayerPrefs.SetInt("lvlI", 0);
	PlayerPrefs.SetInt("lvlJ", 0);
//	PlayerPrefs.SetInt("lvlK", 0);
//	PlayerPrefs.SetInt("lvlL", 0);
//	PlayerPrefs.SetInt("lvlM", 0);
//	PlayerPrefs.SetInt("lvlN", 0);
//	PlayerPrefs.SetInt("lvlO", 0);
//	PlayerPrefs.SetInt("lvlP", 0);
//	PlayerPrefs.SetInt("lvlQ", 0);
//	PlayerPrefs.SetInt("lvlR", 0);
//	PlayerPrefs.SetInt("lvlS", 0);
//	PlayerPrefs.SetInt("lvlT", 0);

		PlayerPrefs.SetInt("stA", 0);
		PlayerPrefs.SetInt("stB", 0);
		PlayerPrefs.SetInt("stC", 0);
		PlayerPrefs.SetInt("stD", 0);
		PlayerPrefs.SetInt("stE", 0);
		PlayerPrefs.SetInt("stF", 0);
		PlayerPrefs.SetInt("stG", 0);
		PlayerPrefs.SetInt("stH", 0);
		PlayerPrefs.SetInt("stI", 0);
		PlayerPrefs.SetInt("stJ", 0);
//		PlayerPrefs.SetInt("stK", 0);
//		PlayerPrefs.SetInt("stL", 0);
//		PlayerPrefs.SetInt("stM", 0);
//		PlayerPrefs.SetInt("stN", 0);
//		PlayerPrefs.SetInt("stO", 0);
//		PlayerPrefs.SetInt("stP", 0);
//		PlayerPrefs.SetInt("stQ", 0);
//		PlayerPrefs.SetInt("stR", 0);
//		PlayerPrefs.SetInt("stS", 0);
//		PlayerPrefs.SetInt("stT", 0);

	//gameScore = crateA+crateB+crateC+crateD+crateE+crateF+crateG+crateH+crateI+crateJ+crateK+crateL+crateM+crateN+crateO+crateP+crateQ+crateR+crateS+crateT;
	PlayerPrefs.SetInt("Player Score", 0);
	}

	public void programmersKey(){
		PlayerPrefs.SetInt("TracksUnLocked", 10);
	}

	public void SetVariablesStat(){
		levelNextStore = levelNext;//made for the loading screen fix
		gameLevelStore = gameLevel;
	}
	public void SetVariablesRevert(){
		levelNext = levelNextStore;	
	}
	public void SetGameLevelLoad(){
		levelNext = gameLevelStore;
	}
	public void GetCurrLevelCode(){
	
		currlevel = gameLevelStore - 7;
	}
	public void setGameScoreValues(){
		shotOnStore = shotOn;
		levelScoreStore = levelScore;
		gameScoreStore = gameScore;
		clockTimerStore = clockTimer;
		shotScoreStore = shotScore;
		scoreCardStore = scoreCard;
		starsTotalStore = starsTotal;
	}
	public void getGameScoreValues(){
		shotOn = shotOnStore;
		levelScore = levelScoreStore;
//		Debug.Log (gameScoreStore);
		gameScore = gameScoreStore;
		clockTimer = clockTimerStore;
		shotScore = shotScoreStore;
		scoreCard = scoreCardStore;
		starsTotal = starsTotalStore;
	}

}
