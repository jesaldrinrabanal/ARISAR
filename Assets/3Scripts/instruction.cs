using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instruction : MonoBehaviour
{
    public GameObject inst;




    public void ShowInst()
    {
        inst.gameObject.SetActive(true);
    }

    public void HideInst()
    {
        inst.gameObject.SetActive(false);
    }

}
