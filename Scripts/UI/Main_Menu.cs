using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main_Menu : MonoBehaviour
{
 public void Play()
    {
        //play button 
        //AudioSourceController.Instance.PlayMusic("Level");
        SceneManager.LoadScene(1);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
