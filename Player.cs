using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public int test;
    
  
    public AudioSource CrashAudio;


    void Start()
    {
        Cursor.visible = false;
    }


    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(pos.x, pos.y, 0);
    }

    
    
    
    
    
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Destroyer")
        {
            StartCoroutine(Lose());
            //Destroy(col.gameObject);
        }







        IEnumerator Lose()
        {
            CrashAudio.Play();
            GetComponent<AudioSource>().Play();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<PolygonCollider2D>().enabled = false;
            yield return new WaitForSeconds(1);
            Application.LoadLevel(0);
        }
    }
}
