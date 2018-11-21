using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlocks : MonoBehaviour {
	private float speed = 20f;
	//private float time = 1f;
	void Start(){
		//as each block is instantiated...its speed will increase by speed/20
		speed += Time.timeSinceLevelLoad/20f;
		Debug.Log (speed);
	}

	void Update () {
		
		this.transform.Translate (Vector3.back * speed * Time.deltaTime);
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "BackCollider") {
			Destroy (this.gameObject);
		}
}
}
