using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{

    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 9f;
    private float countdown = 2f;

    public Text waveCountdownText;

    private int waveNumber = 1;

    bool start = true;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (start == true)
        {


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

        if(waveNumber == 8)
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
