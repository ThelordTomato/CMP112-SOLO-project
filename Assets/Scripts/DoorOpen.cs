using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private bool Done = false;
    public AudioSource DoorAudio;


    void Start()
    {
        DoorAudio = GetComponent<AudioSource>();

    }


    // Update is called once per frame
    void Update()
    {
        if(DoorEnter.Complete == true)
        {
            //used to open final door by transforming it by 90
            
            transform.eulerAngles = new Vector3(0, 0, 0);

            if (Done == false)
            {
                DoorAudio.Play();
                Done = true;
            }
        }
    }
}
