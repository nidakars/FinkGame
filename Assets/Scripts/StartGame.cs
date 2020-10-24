using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void Play()
    {
        Debug.Log("Play");
        SceneManager.LoadScene("GameScene");

    }
    public void PauseGame()
    {
        Debug.Log("Pause");
        SceneManager.LoadScene("PauseScene");
    }
   
}
