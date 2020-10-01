using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud_Control : MonoBehaviour
{
    [SerializeField]
    private float speed=1;
    private bool waiting;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        if (transform.position.y < -10 && !waiting)
        {
            StartCoroutine(RandomWait());
        }
    }


    private IEnumerator RandomWait()
    {
        waiting = true;
        float x = Random.Range(0, 10);

        yield return new WaitForSeconds(x);
        waiting = false;
        transform.position = new Vector3(transform.position.x, 17, 0);
    }
}
