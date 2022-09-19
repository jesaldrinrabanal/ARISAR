using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tagalogs : MonoBehaviour
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
 

   public void SelectTagalog()
    {
       
        pages1.gameObject.SetActive(true);
        pages2.gameObject.SetActive(true);
        pages3.gameObject.SetActive(true);
        pages4.gameObject.SetActive(true);
        pages5.gameObject.SetActive(true);
        pages6.gameObject.SetActive(true);
        pages7.gameObject.SetActive(true);
        pages8.gameObject.SetActive(true);
        pages9.gameObject.SetActive(true);
    }
}
