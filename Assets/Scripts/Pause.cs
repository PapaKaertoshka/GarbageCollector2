using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
   public void OnPause()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
}
