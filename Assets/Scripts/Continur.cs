using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continur : MonoBehaviour
{
    public GameObject pauseMenu;
    public void GetContinue()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
}
