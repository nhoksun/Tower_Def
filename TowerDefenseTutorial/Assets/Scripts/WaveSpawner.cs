using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour {

	public Transform enemyPrefab;

	public Transform spawnPoint;

	public float timeBetweenWaves = 5f;

	private float countdownTime = 2f;
	private int waveIndex = 0 ;

	void Update()
	{
		if (countdownTime <= 0f) 
		{
			StartCoroutine (SpawnWave ());
			countdownTime = timeBetweenWaves;
		}
		countdownTime -= Time.deltaTime;

	}

	IEnumerator SpawnWave()
	{
		waveIndex++;
		//		Debug.Log ("Wave Incomming!!! ");
		for (int i = 0; i < waveIndex; i++) 
		{
			SpawnEnemy ();
			yield return new WaitForSeconds (0.5f);
		}
	}
//	void SpawnWave()
//	{
//		//		Debug.Log ("Wave Incomming!!! ");
//		for (int i = 0; i < waveIndex; i++) {
//
//		}
//		waveIndex++;
//	}

	void SpawnEnemy()
	{
		Instantiate (enemyPrefab, spawnPoint.position, spawnPoint.rotation);
	}
}
