﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaveSpawner : MonoBehaviour
{

    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 9f;
    private float countdown = 2f;

    public Text waveCountdownText;

    private int waveNumber = 1;

    bool start = true;

	public float tiempo;
	public string levelToLoad;

    // Use this for initialization
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		tiempo += Time.deltaTime;

        if (start == true)
        {
			
			if (tiempo >= 60) {

				SceneManager.LoadScene (levelToLoad);
			}

            if (countdown <= 0f)
            {
                StartCoroutine(SpawnWave());
                countdown = timeBetweenWaves;

            }

            countdown -= Time.deltaTime;

            waveCountdownText.text = Mathf.Round(countdown).ToString();
        }

    }

    IEnumerator SpawnWave()
    {
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }

        waveNumber++;

        if(waveNumber == 10)
        {
            start = false;
            countdown = 0;
        }   
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

    }
}