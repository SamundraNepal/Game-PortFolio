using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {


	public static int EnemiesAlive = 0;


	public Wave[] waves;

	public float timeBetweenWaves = 5f;

	public Transform spawnPoint;

	private float CountDown =2f;

	public Text waveCountdownText;

	public GameManager gameManager;


	private int waveIndex = 0;



	void Start ()


	{

		EnemiesAlive = 0;

	}

	void Update ()
	{

		if (EnemiesAlive > 0) {
		
			return;

		}


		if (waveIndex == waves.Length) {

			gameManager.WinLevel ();

			this.enabled = false;

		}


		if (CountDown <= 0f) {

			StartCoroutine(SpawnWave());

			CountDown = timeBetweenWaves;

			return;
		}


		CountDown -= Time.deltaTime;

		CountDown = Mathf.Clamp (CountDown, 0f, Mathf.Infinity);

		waveCountdownText.text = string.Format(" {0:00.00}", CountDown);


	}



	IEnumerator SpawnWave ()
	{
		PlayerStats.Rounds++;

		Wave wave = waves [waveIndex];

		EnemiesAlive = wave.count;

		for( int i =0; i < wave.count; i++)
		{

			SpawnEnemy(wave.enemy);	
			yield return new WaitForSeconds(0f / wave.rate	);
		}
		waveIndex++;
	
	}

	void SpawnEnemy ( GameObject enemy)
	{
		Instantiate (enemy , spawnPoint.position , spawnPoint.rotation);


	}
}
