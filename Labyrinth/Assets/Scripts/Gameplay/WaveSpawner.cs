using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {

    enum SpawnState { SPAWNING, WAITING, COUNTING };

    [System.Serializable]
    public class Wave
    {
        public Transform enemy;
        public int count;
        public float rate;
    }

    public Wave[] waves;
    private int nextWave = 0;

    public Transform[] spawnPoints;

    public float timeBetweenWaves = 1.0f;
    private float waveCountDown = 0;
    SpawnState state = SpawnState.COUNTING;

    private float searchCountDown = 5f;

    WaveMusic waveMusic;

	// Use this for initialization
	void Start () {
        waveCountDown = timeBetweenWaves;
        waveMusic = WaveMusic.instance;

        if (spawnPoints.Length == 0)
        {
            Debug.LogError("No Spawn points");
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (state == SpawnState.WAITING) {
            if (!EnemyIsAlive())
            {
                // Begin a new round
                WaveCompleted();
            }
            else {
                return;
            }
        }

        if (waveCountDown <= 0.0f) {
            if (state != SpawnState.SPAWNING)
            {
                StartCoroutine(SpawnWaves(waves[nextWave]));
            }
        }
        else
        {
            waveCountDown -= Time.deltaTime;
        }
    }

    void WaveCompleted()
    {
        waveMusic.StopWaveSound();
        Debug.Log("Wave complete");
        state = SpawnState.COUNTING;
        waveCountDown = timeBetweenWaves;

        if (nextWave >= waves.Length - 1)
        {
            nextWave = 0;
            print("All waves complete, Looping");
        }
        else {
            nextWave++;
        }
    }

    bool EnemyIsAlive()
    {
        searchCountDown -= Time.deltaTime;
        if (searchCountDown <= 0.0f)
        {
            searchCountDown = 1.0f;
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
                return false;
        }
        return true;
    }

    IEnumerator SpawnWaves(Wave _wave)
    {
        waveMusic.StartWaveSound();
        print("Spawning wave: " + nextWave);
        state = SpawnState.SPAWNING;

        for (int i = 0; i < _wave.count; i++) {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(1f / _wave.rate);
        }

        state = SpawnState.WAITING;
        yield break;
    }

    void SpawnEnemy(Transform _enemy)
    {
        if (spawnPoints.Length == 0) {
            Debug.LogError("No Spawn points");
        }
        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(_enemy, _sp.position, _sp.rotation);
    }
}
