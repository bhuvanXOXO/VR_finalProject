using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAuto : MonoBehaviour
{
    public float waitTime = 30.0f;
    public string sceneLoad;
    private float curTime;


    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime;
        if(curTime > waitTime)
        {
            SceneManager.LoadScene(sceneLoad);
        }
    }
}
