using UnityEngine;
using System.Collections;

public class touchRotate : MonoBehaviour {

    private float turnSpeed = 5f;
    private Vector2 movement;
    private Vector2 movement_mice;
    public bool mouseEnabled = false;
	public float forceAsserted = 0.0f;
	public float rotateAsserted = 0.0f;
	private bool startClick = false;
	private float targetAngle = 0.0f;
    void Update()
    {
        Vector2 currentPosition = transform.position;
        if(Input.GetMouseButton(0) == true)
		{
        	Vector2 moveTowards_mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        	movement_mice = moveTowards_mouse - currentPosition;
        	forceAsserted = -movement_mice.x + 6;
        	movement_mice.Normalize();
        	targetAngle = Mathf.Atan2(movement_mice.y, movement_mice.x) * Mathf.Rad2Deg;

        	rotateAsserted = transform.rotation.z;
        	transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, targetAngle + 180), turnSpeed * Time.deltaTime);
        }
        else
        {
            forceAsserted = 0.0f;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 moveTowards = Camera.main.ScreenToWorldPoint(touch.position);

                movement = moveTowards - currentPosition;
				forceAsserted = -movement.x + 6;				
                movement.Normalize();

				targetAngle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;

				rotateAsserted = transform.rotation.z;
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, targetAngle),  turnSpeed* Time.deltaTime);
				
			}
			else if (touch.phase == TouchPhase.Ended)
			{
				forceAsserted = 0.0f;
			}
		}

    }

}
