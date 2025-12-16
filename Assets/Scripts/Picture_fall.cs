using UnityEngine;

public class Picture_fall : MonoBehaviour
{
    public AudioSource glassAudio;
    private static bool fallen = false; 

    void Start()
    {
        glassAudio = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Winning_Move.Completed == true)
        {

            transform.position = new Vector3(-83, 5, 2263);
            transform.eulerAngles = new Vector3(0, 0, 0);

            //makes it so the audio is only played once
            if (fallen == false)
            {
                glassAudio.Play();
                fallen = true;
            }
           
            
        }



        
    }
}
