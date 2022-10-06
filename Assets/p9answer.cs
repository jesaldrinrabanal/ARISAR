using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p9answer : MonoBehaviour
{
    public GameObject theends;
    public GameObject x;
    public GameObject canvas;
    public void Yes()
    {
        theends.gameObject.SetActive(true);
        Destroy(canvas.gameObject);
    }
    public void No()
    {
        x.gameObject.SetActive(true);
    }

}
