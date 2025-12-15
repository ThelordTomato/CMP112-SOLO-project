using UnityEngine;
using System.Collections;

public class Lockers : MonoBehaviour
{
    public bool Opened = false;
    private Animator LockerAnimation;
    public AudioSource LockerAudio;
    private static bool Done = false;
    public bool Stop = false ;

    void Start()
    {
        LockerAnimation = GetComponent<Animator>();
        LockerAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        OpenChest();

        if (Enter.Done == true && Done == false)
        {
            Opened = true;


            LockerAudio.Play();
            Done = true;
        }
    }

    public void OpenChest()
    {
        if (Opened == true)
        {

            LockerAnimation.SetBool("Opened", true);
            StartCoroutine(RightFrame());


        }
    }

    IEnumerator RightFrame()
    {
        // Wait for 1 second
        yield return new WaitForSeconds(2);

        LockerAnimation.speed = 0f;
        Stop = true;
    }





}
