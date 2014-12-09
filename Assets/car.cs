using UnityEngine;
using System.Collections;

public class car : MonoBehaviour {

	public int dir = 0;
	private bool throttle = false;
	private bool reverse = false;
	public Vector2 direction;
	public Vector2 acceleration =  Vector2.zero;
	public float maxSpeed = 6.0f;
	public float accelerationMag = 0.5f;
	public float deceleration = 0.5f;
	public float turnSpeed = 15.0f;
	public double angle = 0f;

	public int frame;
	private SpriteRenderer spriteRenderer;
	public Sprite[] sprites;

	// Use this for initialization
	void Start () {
		spriteRenderer = renderer as SpriteRenderer;
	}
	
	// Update is called once per frame
	void Update () {
	
		direction = vectorHelper.RotateVector (new Vector2 (1, 0), (float) angle);

		dir = InputHelper.GetDirectionKey ();
		throttle = InputHelper.GetThrottle ();
		reverse = InputHelper.GetReverse ();

		// acceleration/deceleration
		if (throttle == true) {
			acceleration += direction;
			acceleration *= accelerationMag;
				}
		else if (reverse == true) {
			acceleration -= direction;
			acceleration *= accelerationMag;
		}
		else{
			acceleration = -rigidbody2D.velocity;
			acceleration.Normalize();
			acceleration *= deceleration;
		}

		// steering
		if (dir != 0) {
			rigidbody2D.velocity = vectorHelper.RotateVector (rigidbody2D.velocity, dir * turnSpeed);
			angle += dir* turnSpeed ; //*Time.deltaTime
			if (angle < 0)
			{
				angle += 360;
			}
				}
			                                     
		rigidbody2D.velocity += acceleration;

		if (rigidbody2D.velocity.magnitude > maxSpeed) {
			Vector2 normVelocity = rigidbody2D.velocity;
			normVelocity.Normalize ();
			rigidbody2D.velocity = normVelocity * maxSpeed;
				}

		if (rigidbody2D.velocity.magnitude > 0) {
						direction = rigidbody2D.velocity;
						direction.Normalize ();
				}

		frame = (int)((382.5f-Mathf.Abs((float)angle%360))/45.0f)+1;
		if (frame > 8) {
						frame = 8;
				}
		spriteRenderer.sprite = sprites [frame-1];
		rigidbody2D.transform.eulerAngles = Vector3.zero;
	}

}
