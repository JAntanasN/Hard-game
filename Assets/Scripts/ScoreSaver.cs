using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreSaver : MonoBehaviour
{
    public TextMeshPro scoreBox;

    private float bestScore = float.PositiveInfinity;

    // Start is called before the first frame update
    void Start()
    {
        var timer = FindObjectOfType<Timer>();
        timer.isActive = false;

        // deactive TimerText
        GameObject.Find("TimerText").SetActive(false);

        //check if there is a best time saved
        if (PlayerPrefs.HasKey("bestScore"))
        {
            bestScore = PlayerPrefs.GetFloat("bestScore");
        }

        if(timer.time < bestScore)
        {
            bestScore = timer.time;
            PlayerPrefs.SetFloat("bestScore", bestScore);
            PlayerPrefs.Save();
        }

        //display final score
        scoreBox.text = $"Your time: {timer.GetTimeString(timer.time)}\n";

        scoreBox.text += $"Best time: {timer.GetTimeString(bestScore)}";
    }
}
