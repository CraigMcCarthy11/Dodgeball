using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject enemy;
    public Transform[] spawnSpots;
    private float timeBtwnSpawns;
    public float startTimeBtwnSpawns;

	// Use this for initialization
	void Start () {
        timeBtwnSpawns = startTimeBtwnSpawns;
	}
	
	// Update is called once per frame
	void Update () {
	    if (timeBtwnSpawns <= 0)
        {
            int randPos = Random.Range(0, spawnSpots.Length);
            Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);
            timeBtwnSpawns = 2;
        }
        else
        {
            timeBtwnSpawns -= Time.deltaTime;
        }
	}
}
