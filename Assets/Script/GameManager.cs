using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	private float slowness = 10f;

	public void EndGame(){
		Debug.Log ("apadlo");
		StartCoroutine (Restart());
	}

	IEnumerator Restart(){
	//before 5 seconds

		//when hit by a block a slo-mo effect will be given
		Time.timeScale = 1f/slowness;
		Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

		yield return new WaitForSeconds(5f/slowness);//wait for 5 sec.......devide by slowness because it should get 5sec in real-time

	//after 5 seconds

		//Now that the 5secs are over we will change the scene..and return time to original value

		Time.timeScale = 1f;
		Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

		SceneManager.LoadScene (2);
	}
}
