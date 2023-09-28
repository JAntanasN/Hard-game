using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoverBot : MonoBehaviour
{
    public float speed = 3;
    [Range(0.1f, 1)]
    public float minDistance = 0.3f;

    Vector3 target;
    public List<Vector3> path = new(); //public pridejau
    int targetIndex = 0;

    private void Start()
    {
        //get children
        foreach (Transform child in transform)
        {
            path.Add(child.position);
        }

        //start from the first point
        target = path[0];
    }

    void Update()
    {
        var direction = target - transform.position;
        var distance = direction.magnitude;

        //move towards target
        transform.position += direction.normalized * speed * Time.deltaTime;

        //check if target is reached - next target
        if(distance <= minDistance)
        {
            targetIndex++;

            //check if end of path then loop
            if (targetIndex >= path.Count) targetIndex = 0;

            target = path[targetIndex];
        } 
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        for (int i = 0; i < path.Count - 1; i++)
        {
            Gizmos.DrawLine(path[i], path[i + 1]);
        }
        Gizmos.DrawLine(path[0], path[path.Count-1]);
    }
}
