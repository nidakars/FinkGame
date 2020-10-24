using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    [SerializeField]
    GameObject _settings;
    [SerializeField]
    GameObject _pause;
    

    public void Pause()
    {
        _pause.SetActive(true);
        _settings.SetActive(false);
       
    }
    public void Settings()
    {
        Debug.Log("settings");
        _settings.SetActive(true);

        _pause.SetActive(false);
    }
}
