using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BGM : MonoBehaviour
{
    public static BGM bgmusic;
    
    void Awake()
    {
        if(bgmusic == null)
        {
            bgmusic = this;
            DontDestroyOnLoad(bgmusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "Manok 2"|| currentScene.name == "English" || currentScene.name == "Merge" || currentScene.name == "Old-English")
        {
            // Stops playing music in level 1 scene
            Destroy(gameObject);
        }
    }
}
