using UnityEngine;

public class Num2 : MonoBehaviour
{
    public Num1 button;
    private AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }



    void OnMouseDown()
    {

        if (button.sequence == 1)
        {

            button.sequence = 2;
            Debug.Log("Works");



        }
        else
        {
            button.sequence = 0;
        }


        sound.Play();


    }



}
