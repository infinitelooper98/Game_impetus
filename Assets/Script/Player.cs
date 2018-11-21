using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {
	private float horspeed = 200f;

	private float dirX;

	private Rigidbody rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void Update(){
		dirX = CrossPlatformInputManager.GetAxis ("Horizontal") * horspeed *Time.deltaTime;
		rb.velocity = new Vector3(dirX,0,0);
	}

	void OnCollisionEnter(Collision col){

		//if player colides with the block...the game manager will get run...with 5seconds of lag and game over

		if (col.gameObject.tag == "Block") {
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}
}