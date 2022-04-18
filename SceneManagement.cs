using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    private int index;
    
    // Start is called before the first frame update
    void Start()
    {

        Scene m_Scene = SceneManager.GetActiveScene();
        string sceneName = m_Scene.name;

        if (sceneName == "Scene1")
        {
            index = 1;
        }
        else if (sceneName == "Scene2")
        {
            index = 2;
        }
        else if (sceneName == "Scene3")
        {
            index = 3;
        } else {
            index = 0;
        }

        if (sceneName != "Title")
        {
            PlayerPrefs.SetInt("Sceneindex", index);
        }
    }

    public void OnNextScene()
    {
        SceneManager.LoadScene("Scene" + index);
    }

    public void OnLoadLatest()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Sceneindex", 1));
    }
}
