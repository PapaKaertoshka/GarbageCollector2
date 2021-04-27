using System;
using System.Collections;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public GameObject endGame, scoreTxt;
    [SerializeField]
    private Text txt, score;
    private int _seconds = 20;
    private const string TimerString = "Time:";
    private IEnumerator Time()
    {
        var waiter = new WaitForSeconds(1);
        while (_seconds >= 0)
        {
            yield return waiter;

            txt.text = TimerString + _seconds;
            _seconds--;
        }
        endGame.SetActive(true);
        score.text = "Your score: " + scoreTxt.GetComponent<Scoring>().score;
    }
    void Start()
    {
        StartCoroutine(Time());
    }
}