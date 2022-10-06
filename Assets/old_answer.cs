using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class old_answer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject correct;
    public GameObject finish;
    public GameObject Bluex;
    public GameObject Sapphirex;
    public GameObject Purpx;
    public GameObject goldx;
    public GameObject tagalogsbukas;
    public GameObject tagalogsarado;
    public void Gold()
    {
        Debug.Log("GOLD");
        finish.gameObject.SetActive(true);
        correct.gameObject.SetActive(false);
        goldx.gameObject.SetActive(true);
        //BUKAS
        tagalogsbukas.gameObject.SetActive(true);
        //SARADO
        tagalogsarado.gameObject.SetActive(false);
    }
    public void Blue()
    {
        Debug.Log("Blue");
        Bluex.gameObject.SetActive(true);
    }
    public void Sapphire()
    {
        Debug.Log("Sapphire");
        Sapphirex.gameObject.SetActive(true);
    }
    public void Purp()
    {
        Debug.Log("Purp");
        Purpx.gameObject.SetActive(true);
    }
}
