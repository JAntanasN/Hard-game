using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // add using

public class Timer : MonoBehaviour
{
    public TextMeshPro timeBox;
    public bool isActive = true;


   
    [HideInInspector]
    public float time = 0;


    //Don't reset time
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(timeBox.gameObject);
    }
    void Update()
    {
        if (isActive)
        {
            time += Time.deltaTime;
        }
        //time += Time.deltaTime;

        timeBox.text = GetTimeString(time);

        
    }

    public string GetTimeString(float t)
    {
        return t.ToString();
    }
}
