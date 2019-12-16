using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{


    void Start()
    {
        Cursor.visible = true;
    }


    



  

    public void StartGame()
    {
        Application.LoadLevel(2);
    }
}

