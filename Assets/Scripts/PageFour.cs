using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageFour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Food"))
        {
            Destroy(other.gameObject);
            
        }
    }
}
