using UnityEngine;

public class WrongNums : MonoBehaviour
{
 public Num1 button;
    private AudioSource sound;


    void Start()
    {
        sound = GetComponent<AudioSource>();
    }



    void OnMouseDown()
    {
        button.sequence = 0;
        sound.Play();
    }



}


