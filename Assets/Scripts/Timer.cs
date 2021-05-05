using System;
using System.Collections;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private UnityEvent OnGameEnd;
    [SerializeField] private Text timerText;
    public int levelDuration = 20;
    private int timePassed = 0;
    private const string TimerString = "Time: ";
    void Start()
    {
        StartCoroutine(TimeCountdown());
    }
    private IEnumerator TimeCountdown()
    {
        while (timePassed <= levelDuration)
        {
            yield return new WaitForSeconds(1);
            timerText.text = TimerString + (levelDuration - timePassed);
            timePassed++;
        }
        OnGameEnd?.Invoke();
    }
}