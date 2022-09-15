using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public GameObject quiz;
    public GameObject tupa;
    public GameObject baka;
    public GameObject baboy;

    public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("Correct Answer");
            quiz.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Wrong Answer");
            
        }
    }
    public void Tupa()
    {
        tupa.gameObject.SetActive(true);
    }
    public void Baka()
    {
        baka.gameObject.SetActive(true);
    }
    public void Baboy()
    {
        baboy.gameObject.SetActive(true);
    }
}
