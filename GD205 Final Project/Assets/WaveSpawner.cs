using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countDown = 2f;

    public Text waveCountdownText;

    private int waveIndex = 0;

    void Update()
    {
        if (countDown <= 0f)
        {
            //Since im using a IEumerator I need to use "StartCoroutine" to use the custum function
            StartCoroutine(SpawnWave());
            countDown = timeBetweenWaves;
        }

        //deltaTime is usefull for ensuring things dont run based on the players framerate but on actual real time
        countDown -= Time.deltaTime;

        //setting the text to the countdown
        waveCountdownText.text = Mathf.Round(countDown).ToString();
    }

    //IEnumerator allows us to use the "yield return new WaitForSeconds" which in this case will wait 0.5 seconds before running the code again
    IEnumerator SpawnWave()
    {
        waveIndex++;

        //A type of loop that contains its own varible, condition and increases/decreases to that variable
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }

    }

    void SpawnEnemy()
    {
        //Spawns a enemy prefab
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
