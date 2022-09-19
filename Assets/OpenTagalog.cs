using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTagalog : MonoBehaviour
{
    public GameObject tagsub;
  

    public void Tags()
    {
        tagsub.gameObject.SetActive(true);
    }
    public void closeTags()
    {
        tagsub.gameObject.SetActive(false);
    }
}
