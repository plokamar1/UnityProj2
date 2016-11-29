using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed;
	public GameObject deathParticles;

	private float maxSpeed = 5f;
	private Vector3 input;
	private Vector3 spawn;

	void Start () {
		spawn = transform.position;
	}
	

	void Update () {

		if (rigidbody.velocity.magnitude < maxSpeed) {
			rigidbody.AddForce(input * moveSpeed);	
		}

		input = new Vector3 (Input.GetAxis ("Horizontal"),0 , Input.GetAxis ("Vertical"));
		transform.position += input * moveSpeed * Time.deltaTime;	




		if (transform.position.y < -2) {
			Die();		
		}

	}

	void OnCollisionEnter(Collision other){
		if (other.transform.tag == "Enemy") {
			Die();
		}

	}

	void OnTriggerEnter(Collider other){
		if (other.transform.tag == "Goal") {
			GameManager.completeLevel();
		}
	}

	void Die(){
		print ("I hit Enemy");
		Instantiate(deathParticles, transform.position, Quaternion.Euler(270,0,0));
		transform.position = spawn;
	}
}

