using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lastpage : MonoBehaviour
{
    public GameObject complete;
    public GameObject wrong;
    public GameObject lesson;
    public GameObject text1;
    public GameObject text2;

    public void Correct() {
        complete.gameObject.SetActive(true);
        Destroy(wrong.gameObject);
        Debug.Log("Correct!");
        lesson.SetActive(true);
        
        text2.SetActive(false);
    }
    public void Wrong() {
        wrong.gameObject.SetActive(true);
        Debug.Log("Wrong!");

    }
 
}
