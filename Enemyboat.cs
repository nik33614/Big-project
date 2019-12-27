using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyboat : MonoBehaviour
{

    public float Speed = 2;
    
    Vector3 target;


    
    void Update()
    {
        //searching for player
        target = GameObject.FindWithTag("Player").transform.position;
        // go to target
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * Speed);
    }
}
