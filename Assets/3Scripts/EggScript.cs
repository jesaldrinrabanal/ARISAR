using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour
{
    public GameObject egg1;
    public GameObject egg2;
    public GameObject egg3;
    public GameObject egg4;
    public GameObject egg5;
    public GameObject destroyObject;
    public GameObject completed;
    public int eggCount = 0;
    public GameObject tagalogsbukas;
    public GameObject tagalogsarado;
    public AudioSource eatsound;
    public void Update()
    {
        if (eggCount == 5)
        {
            Debug.Log("Complete");
            destroy();
            completed.gameObject.SetActive(true);
            //BUKAS
            tagalogsbukas.gameObject.SetActive(true);
            //SARADO
            tagalogsarado.gameObject.SetActive(false);
        }
    }
    public void destroy()
    {
        Destroy(destroyObject.gameObject);
    }
    public void eggFound()
    {
        Debug.Log("Egg Found");
        eggCount++;
        eatsound.Play();
    }
    public void Egg1()
    {
        egg1.gameObject.SetActive(false);
    }
    public void Egg2()
    {
        egg2.gameObject.SetActive(false);
    }   
    public void Egg3()
    {
        egg3.gameObject.SetActive(false);
    }
    public void Egg4()
    {
        egg4.gameObject.SetActive(false);
    }
    public void Egg5()
    {
        egg5.gameObject.SetActive(false);
    }
}
