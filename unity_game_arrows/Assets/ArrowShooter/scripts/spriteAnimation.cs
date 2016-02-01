using UnityEngine;
using System.Collections;

public class spriteAnimation : MonoBehaviour {
	public int columns = 8;
	public int rows = 8;

	//Animation
	public bool deadAnim = false;
	public bool hitAnim = false;
	public int currentFrame = 0;
	public float animTime = 0.0f;
	public int currentAnimation = 0;
	private Vector2 framePosition;
	private Vector2 frameSize;
	private Vector2 frameOffset;
	private int i = 0;
	//Animation Frames
	private int walkMin= 1;
	private int walkMax= 6;

	private int deadMin= 6;
	private int deadMax= 8; 

	private int hitMin= 1;
	private int hitMax= 3; 

	public int fps = 6;
	private int animWalk = 0;
	private int animdead = 1;
	private int animHit = 2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		handleAnimation ();
		if (deadAnim) {

		}
	}
	void handleAnimation(){
		findAnimation ();
		PlayAnimation ();
		}
	void findAnimation(){
		currentAnimation = animWalk;
	}
	void PlayAnimation(){
		animTime -= Time.deltaTime;
		if (animTime <= 0) {
			currentFrame += 1;
			animTime +=1.0f/fps; 
		}
		if (deadAnim) {
			currentAnimation = animdead;
		}
		if (hitAnim) {
			currentAnimation = animHit;
		}
		if (currentAnimation == animWalk) {
			currentFrame = Mathf.Clamp(currentFrame,walkMin,walkMax + 1);
			if(currentFrame > walkMax)
			{
				currentFrame = walkMin;
			}
			}
		if (currentAnimation == animdead) {
			currentFrame = Mathf.Clamp(currentFrame,deadMin,deadMax);
		}
		if (currentAnimation == animHit) {
			currentFrame = Mathf.Clamp(currentFrame,hitMin,hitMax+1);
			if(currentFrame > hitMax)
			{
				currentFrame = hitMin;
			}
		}
		framePosition.y = 1;

		for(i = currentFrame;i > columns; i -= rows) 
		{
			framePosition.y += 1;
		}
		framePosition.x = i - 1; 
		frameSize = new Vector2(1.0f/columns, 1.0f/rows);
		frameOffset = new Vector2 (framePosition.x/columns, 1.0f - framePosition.y/rows);
		GetComponent<Renderer>().material.SetTextureScale("_MainTex", frameSize);
		GetComponent<Renderer>().material.SetTextureOffset("_MainTex", frameOffset);
	}
}
