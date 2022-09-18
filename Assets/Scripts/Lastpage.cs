using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lastpage : MonoBehaviour
{
    public GameObject complete;
    public GameObject worng;

    public void Correct() {
        complete.gameObject.SetActive(true);
    }
    public void Wrong() {
        worng.gameObject.SetActive(true);

    }
}
