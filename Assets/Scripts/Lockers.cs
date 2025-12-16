using UnityEngine;
using System.Collections;

public class Lockers : MonoBehaviour
{
    public static bool Opened = false;
    private Animator LockerAnimation;
    public AudioSource LockerAudio;
    private static bool Done = false;
    public bool Stop = false ;

    void Start()
    {
        LockerAnimation = GetComponent<Animator>();
        LockerAudio = GetComponent<AudioSource>();

        if (Opened == true)
        {
            LockerAnimation.speed = 0f;
            //Used to make sure when the player loads in again from another scene they still have the locker opened
            LockerAnimation.Play("SM_Locker_Door|SM_Locker_DoorAction", 0, 0.6f);


        }
    }

    void Update()
    {
        

        if (Enter.Done == true && Done == false)
        {
            Opened = true;

            OpenLocker();

            LockerAudio.Play();
            Done = true;
        }
    }

    public void OpenLocker()
    {
        if (Opened == true)
        {

            LockerAnimation.SetBool("Opened", true);
            //waits 2 seconds and stops locker animation since it will close without this
            StartCoroutine(RightFrame());


        }
    }

    IEnumerator RightFrame()
    {
        yield return new WaitForSeconds(2);

        LockerAnimation.speed = 0f;
        Stop = true;
    }





}
