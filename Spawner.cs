using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour

{
    public Transform SpawnPosition;
    public GameObject[] Actors;
    public float TimeRange;
    public float X;

    float time;

    void Update()
    {
        time += Time.deltaTime;

        if (time >= TimeRange)
        {
            Vector3 pos = new Vector3(Random.Range(-X, X), SpawnPosition.position.y, 0);
            Instantiate(Actors[Random.Range(0, Actors.Length)], pos, Quaternion.identity);
            time = 0;
        }
    }
}


