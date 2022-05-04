using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{

    public string sceneName;
    public void StartButton()  // called on 'start' button click, through inspector
    {
        
        SceneManager.LoadScene(sceneName);
    }
}


