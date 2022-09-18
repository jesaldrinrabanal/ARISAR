using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lastpage : MonoBehaviour
{
    public GameObject complete;
    public GameObject wrong;

    public void Correct() {
        complete.gameObject.SetActive(true);
        Destroy(wrong.gameObject);
        Debug.Log("Correct!");
    }
    public void Wrong() {
        wrong.gameObject.SetActive(true);
        Debug.Log("Wrong!");

    }
}
