using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    private static BGM bgmusic;
    
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
}
