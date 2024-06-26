using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] int timeToWait = 3;
    int currentSceneIndex;
    [SerializeField] int scene;

    private void Start()
    {

        StartCoroutine(WaitForTime());


    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);

        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(scene);
    }
}
