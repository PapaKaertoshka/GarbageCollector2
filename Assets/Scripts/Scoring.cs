using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Scoring : MonoBehaviour
{
    public static int Score = 0;
    public void AddScore()
    {
        Score++;
    }
    public void OnDestroy()
    {
        Score = 0;
    }
}
