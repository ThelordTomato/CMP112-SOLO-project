using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textTime;
    float TimeElapsed;


    void Update()
    {
        TimeElapsed += Time.deltaTime;
        textTime.text = TimeElapsed.ToString();


    }
}
