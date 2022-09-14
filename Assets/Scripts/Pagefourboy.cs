using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pagefourboy : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
  void Cheer()
    {
        anim.SetBool("Cheer", true);
    }
}
