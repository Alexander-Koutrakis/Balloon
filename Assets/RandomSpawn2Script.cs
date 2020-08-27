using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn2Script : MonoBehaviour
{
   // public GameObject prefab1, prefab2, prefab3, prefab4, prefab5, prefab6, prefab7, prefab8, prefab9, prefab10, prefab11, prefab12, prefab13, prefab14, prefab15;
    public List<GameObject> spawnGameobjects=new List<GameObject>();
    public float spawnRate = 1f;

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
            // whatToSpawn = Random.Range(1, 16);
            whatToSpawn = Random.Range(0, spawnGameobjects.Count);
            Instantiate(spawnGameobjects[whatToSpawn ], transform.position, Quaternion.identity);

            //switch (whatToSpawn)
            //{
            //    case 1:
            //        Instantiate(prefab1, transform.position, Quaternion.identity);
            //        break;
            //    case 2:
            //        Instantiate(prefab2, transform.position, Quaternion.identity);
            //        break;
            //    case 3:
            //        Instantiate(prefab3, transform.position, Quaternion.identity);
            //        break;
            //    case 4:
            //        Instantiate(prefab4, transform.position, Quaternion.identity);
            //        break;
            //    case 5:
            //        Instantiate(prefab5, transform.position, Quaternion.identity);
            //        break;
            //    case 6:
            //        Instantiate(prefab6, transform.position, Quaternion.identity);
            //        break;
            //    case 7:
            //        Instantiate(prefab7, transform.position, Quaternion.identity);
            //        break;
            //    case 8:
            //        Instantiate(prefab8, transform.position, Quaternion.identity);
            //        break;
            //    case 9:
            //        Instantiate(prefab9, transform.position, Quaternion.identity);
            //        break;
            //    case 10:
            //        Instantiate(prefab10, transform.position, Quaternion.identity);
            //        break;
            //    case 11:
            //        Instantiate(prefab11, transform.position, Quaternion.identity);
            //        break;
            //    case 12:
            //        Instantiate(prefab12, transform.position, Quaternion.identity);
            //        break;
            //    case 13:
            //        Instantiate(prefab13, transform.position, Quaternion.identity);
            //        break;
            //    case 14:
            //        Instantiate(prefab14, transform.position, Quaternion.identity);
            //        break;
            //    case 15:
            //        Instantiate(prefab15, transform.position, Quaternion.identity);
            //        break;
            //}
            float x = Random.Range(3.0f, 9.0f);
            spawnRate = x;
            nextSpawn = Time.time + spawnRate;
        }
    }

}
