using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystickshow : MonoBehaviour
{
    public GameObject joystick;

    public void show()
    {
        joystick.gameObject.SetActive(true);
    }
}
