using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoScript : MonoBehaviour
{
    public GameObject video;

    public void OpenVid()
    {
        video.gameObject.SetActive(true);
    }

    public void CloseVid()
    {
        video.gameObject.SetActive(false);
    }
}
