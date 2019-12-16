using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yimer : MonoBehaviour
{
    public int Scores;
    public UnityEngine.UI.Text ScoresText;
    public float timeRemaining = 60f;


    void Start()
    {
        InvokeRepeating("RunTimer", 1, 1);
    }

    void RunTimer()
    {
        ScoresText.text = (int.Parse(ScoresText.text) + 1).ToString();
    }
}






