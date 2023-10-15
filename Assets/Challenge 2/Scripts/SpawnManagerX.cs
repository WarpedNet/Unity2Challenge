using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 20;

    private float startDelay = 1.0f;
    private float spawnIntervalUpper = 5.0f;
    private float spawnIntervalLower = 3.0f;
    public float spawnIntervalVarible = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", spawnIntervalVarible);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        spawnIntervalVarible = Random.Range(spawnIntervalLower, spawnIntervalUpper);
        Invoke("SpawnRandomBall", spawnIntervalVarible);
    }

}
