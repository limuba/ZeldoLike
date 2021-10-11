using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //list d'ennemis
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    [SerializeField] private float time;
    [SerializeField] private float waitTime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > waitTime)
        {
            int randEnemy = Random.Range(0, enemyPrefabs.Length);
            int randSpawnPoints = Random.Range(0, spawnPoints.Length);

            Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoints].position, transform.rotation);

            time = time - waitTime;
        }

    }
}
