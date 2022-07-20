using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NoteAccuracy : MonoBehaviour
{
    public int Score;
    public float Accuracy;
    public NoteMiss noteMiss;
    public Text accuracyText;
    public Text scoreText;
    void Start()
    {
        
    }

    void Update()
    {
        // NoteNice %= noteMiss.miss;
        if (Accuracy <= 0)
        {
            Accuracy = 0;
        }
        if (Accuracy >= 100)
        {
            Accuracy = 100;
        }
       accuracyText.text = "Accuracy:" + Accuracy + "%";
        scoreText.text = "Score:" + Score;
    }
}
