using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

    public int Level;

    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(Level);
        PlayerPrefs.SetInt("Level_" + Level,1);
    }
}
