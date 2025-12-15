using UnityEngine;

public class ChestAnimator : MonoBehaviour
{
    public bool Open = false;
    private Animator chestAnimation;
    public AudioSource ChestAudio;
    private static bool Done = false;

    void Start()
    {
        chestAnimation = GetComponent<Animator>();
        ChestAudio = GetComponent<AudioSource>();
    }

    void Update() 
    {
      OpenChest();

        if (GameManager_script.Finished == true && Done == false)
        {
            Open = true;


            ChestAudio.Play();
            Done = true;
        }
    }

    public void OpenChest()
    {
        if (Open == true) {

            chestAnimation.SetBool("Open", true);
        
        
        }
    }
}
