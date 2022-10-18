using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScript : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;


    public void pageOne()
    {
        page1.gameObject.SetActive(false);
        page2.gameObject.SetActive(true);
    }
    public void pageTwo()
    {
        page2.gameObject.SetActive(false);
        page3.gameObject.SetActive(true);
    }
    public void pageTwoBack()
    {
        page1.gameObject.SetActive(true);
        page2.gameObject.SetActive(false);
    }
    public void pageThree()
    {
        page3.gameObject.SetActive(false);
        page4.gameObject.SetActive(true);
    }
    public void pageThreeBack()
    {
        page3.gameObject.SetActive(false);
        page2.gameObject.SetActive(true);
    }
    public void pageFourBack()
    {
        page4.gameObject.SetActive(false);
        page3.gameObject.SetActive(true);
    }

}
