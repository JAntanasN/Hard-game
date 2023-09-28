using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform target;
    public float speed = 2;
    //distance to follow(1)
    public float followdistance = 5;

    void Update()
    {
        var direction = target.position - transform.position;
        //(1)
        var distance = direction.magnitude; 
        direction.Normalize();

        //(1- if)
        if (distance <= followdistance)
        {
            transform.position += direction * speed * Time.deltaTime;
        }
        
    }
}
