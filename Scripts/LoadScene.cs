using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    int sceneIndex;

    public void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    public void LoadSceneByIndex()
    {
        SceneManager.LoadScene((sceneIndex + 1) % 3);
    }
}
