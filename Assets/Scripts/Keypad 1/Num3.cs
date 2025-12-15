using UnityEngine;

public class Num3 : MonoBehaviour
{
    public Num1 button;

    private AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }


    void OnMouseDown()
    {

        if (button.sequence == 2)
        {

            button.sequence = 3;
            Debug.Log("Works");



        }
        else
        {
            button.sequence = 0;
        }

        sound.Play();



    }



}
