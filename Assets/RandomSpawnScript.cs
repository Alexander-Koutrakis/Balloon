using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnScript : MonoBehaviour
{
    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5;

    public float spawnRate = 2f;

    float nextSpawn = 0f;

    int whatToSpawn;


    private void Start()
    {
        float x = Random.Range(1.0f, 5.0f);
      
        nextSpawn = x;

    }


    private void Update()
    {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 6);
            

            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(prefab1, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(prefab2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(prefab3, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(prefab4, transform.position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(prefab5, transform.position, Quaternion.identity);
                    break;
            }
            float x = Random.Range(3.0f, 12.0f);
            spawnRate = x;
            nextSpawn = Time.time + spawnRate;
        }
    }

}
