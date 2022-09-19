using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class page1track : MonoBehaviour
{
    // Start is called before the first frame update
    public  AudioSource p1;


    private bool tag = false;
    public void Play()
    {
        if (tag == true)
        {
            p1.Play();
        }
    }
}
