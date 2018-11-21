using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;

	private float distance = 20f;

	private float lift = 10f ;

	void Update () {
		transform.position = target.position + (new Vector3(0,lift,-distance));
		//transform.LookAt (target);
	}
}
