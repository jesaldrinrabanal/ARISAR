using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nogame : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public float time; 
    public void Count()
    {
        StartCoroutine(WaitBef());
    }
    private IEnumerator WaitBef()
    {
        yield return new WaitForSeconds(time);
        text1.SetActive(false);
        text2.SetActive(true);
    }
    public void Kist()
    {
        text1.SetActive(true);
        text2.SetActive(false);

    }
  
    
}
