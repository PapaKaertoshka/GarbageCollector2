using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public GameObject trashcan1, trashcan2, trashcan3;
    public int score, score1, score2, score3;
    public Text txt;
    void Update()
    {
        score1 = trashcan1.GetComponent<Comparing>().score;
        score2 = trashcan2.GetComponent<Comparing>().score;
        score3 = trashcan3.GetComponent<Comparing>().score;
        score = score1 + score2 + score3; 
        txt.text = "Score: " + score;
    }
}
