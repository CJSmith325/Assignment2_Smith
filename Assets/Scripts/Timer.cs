using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60;
    public string sceneName;
    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining = Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
