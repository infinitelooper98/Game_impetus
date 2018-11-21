using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Transform[] spawnpoint;

	public GameObject prefeb;

	private float timeBeweenWave = 5f; //the time between the next block will get spawned

	private float timeToSpawn = 1f; //When 1st block will get spawned

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time >= timeToSpawn) {

			SpawnBlocks ();

			timeToSpawn = Time.time + timeBeweenWave;
		}
		
	}

	void SpawnBlocks(){
		int random_Index = Random.Range (0, spawnpoint.Length); //selecting a random number from a range of numbers

		for (int i = 0; i < spawnpoint.Length; i++) {

			if (random_Index != i) {
				Instantiate (prefeb, spawnpoint [i].position, Quaternion.identity);
			}
		}
	}
}
