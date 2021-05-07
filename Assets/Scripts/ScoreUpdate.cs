using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    private string initialText;
    private Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text>();
        initialText = scoreText.text;
    }

    void Update()
    {
        scoreText.text = initialText + Scoring.Score;
    }
}
