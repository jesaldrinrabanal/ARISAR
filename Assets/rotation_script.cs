using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_script : MonoBehaviour
{
    float speed = 23f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
