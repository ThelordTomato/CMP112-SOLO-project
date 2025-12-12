using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textTime;
    float TimeElapsed = 1800;


    void Update()
    {
        TimeElapsed -= Time.deltaTime;
        int mins = Mathf.FloorToInt(TimeElapsed / 60);
        int seconds = Mathf.FloorToInt(TimeElapsed % 60);
        textTime.text = "Time Left: " + string.Format("{0:00}:{1:00}",mins,seconds);

    }
}
