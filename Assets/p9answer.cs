using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p9answer : MonoBehaviour
{
    public GameObject theends;
    public GameObject x;
    public GameObject canvas;
    public GameObject tagalogsbukas;
    public GameObject tagalogsarado;
    public void Yes()
    {
        theends.gameObject.SetActive(true);
        Destroy(canvas.gameObject);
        //BUKAS
        tagalogsbukas.gameObject.SetActive(true);
        //SARADO
        tagalogsarado.gameObject.SetActive(false);
    }
    public void No()
    {
        x.gameObject.SetActive(true);
    }

}
