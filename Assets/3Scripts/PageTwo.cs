using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PageTwo : MonoBehaviour
{


    public GameObject On;
    public GameObject joystick;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Finish"))
        {
            Destroy(other.gameObject);
            On.gameObject.SetActive(true);
            joystick.gameObject.SetActive(false);
        }
    }

}
