using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Englishs : MonoBehaviour
{

    public GameObject pages1;
    public GameObject pages2;
    public GameObject pages3;
    public GameObject pages4;
    public GameObject pages5;
    public GameObject pages6;
    public GameObject pages7;
    public GameObject pages8;
    public GameObject pages9;




    // Update is called once per frame
    public void SelectEnglish()
    {
        
        pages1.gameObject.SetActive(false);
        pages2.gameObject.SetActive(false);
        pages3.gameObject.SetActive(false);
        pages4.gameObject.SetActive(false);
        pages5.gameObject.SetActive(false);
        pages6.gameObject.SetActive(false);
        pages7.gameObject.SetActive(false);
        pages8.gameObject.SetActive(false);
        pages9.gameObject.SetActive(false);
       
    }
}
