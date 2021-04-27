using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public GameObject player, mainMenu, inGame;
    public void StarLevel()
    {
        player.SetActive(true);
        inGame.SetActive(true);
        mainMenu.SetActive(false);
    }
}
