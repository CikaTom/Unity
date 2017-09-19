using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
/***************************************************
* Class responsible for Levelmanagers
* 
* Loading differences scenes
* 
* *********************************************/
public class LevelManager : MonoBehaviour
{

    public float autoLoadNextLevelAfter;

    void Start()
    {
        if (autoLoadNextLevelAfter <= 0)
        {
            Debug.Log("Level auto disabel, use a positivee number in seconds");
        }
        else
        {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }
    }
    public void LoadLevel(string name)
    {
        Debug.Log("New level load:" + name);
        SceneManager.LoadScene(name);
    }
    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
