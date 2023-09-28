using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;

    void Update()
    {
        //Rotate(0, speed * Time.deltaTime, 0)
        transform.Rotate(Vector3.up * speed * Time.deltaTime); 
    }
}
