using UnityEngine;
using System.Collections;

public class DemonBehaviour : MonoBehaviour {

	public Animator anim;
	public car car;
	public float speed = 0;
	public Vector3 velocity = Vector2.zero;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetFloat ("Movement", speed);

		if (Mathf.Abs((car.transform.position - transform.position).magnitude) < 6.0f) {
						speed = 0.05f;
			velocity = car.transform.position - transform.position;
						velocity.Normalize ();
						velocity *= speed;
						this.transform.position += velocity;

				} else {
						speed = 0;
				}
	}
}
