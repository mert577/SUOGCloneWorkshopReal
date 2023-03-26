using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] GameObject wideObstaclePrefab;

    [SerializeField] float spawnTimeMin= .8f;
    [SerializeField] float spawnTimeMax= 1.3f;



    void Start()
    {
        StartCoroutine(SpawnObstacle());
    }


    IEnumerator SpawnObstacle(){
        while(true){
            
            GameObject obstacleToSpawn;

            if(Random.value <.5f){
                obstacleToSpawn = obstaclePrefab;
            }
            else{
                obstacleToSpawn = wideObstaclePrefab;
            }


            Instantiate(obstacleToSpawn, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(  Random.Range(spawnTimeMin, spawnTimeMax));
        }
    }
}