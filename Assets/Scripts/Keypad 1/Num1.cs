using UnityEngine;

public class Num1 : MonoBehaviour
{
    public int sequence = 0;
    private AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }



    void OnMouseDown() {
    
    if (sequence == 0)
        {

            sequence = 1;



        }
        else
        {
            sequence = 0;
        }
    
    
    sound.Play();
    
    
    }


    
}
