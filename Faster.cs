using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public float Speed = 1;


    void Update()
    {
        transform.Translate(new Vector3(-Speed * Time.deltaTime, 0, 0));
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Cheker")
        {
            Speed += 1;
        }
    }
}