using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour
{
    public int eggCount;
   public void Update()
    {
        if (eggCount == 5)
        {
            Debug.Log("Complete");
        }
    }
    public void eggFound()
    {
        eggCount++;
    }
}
