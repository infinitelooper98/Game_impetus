using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideCollider : MonoBehaviour {

	void OnCollisionEnter(Collision col){

		//if theball falls out of the platform game wil end

		if (col.gameObject.tag == "Player") {
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}
}
