using UnityEngine;

public class ChestAnimator : MonoBehaviour
{
    public bool Open = false;
    private Animator chestAnimation;


    void Start()
    {
        chestAnimation = GetComponent<Animator>();
    }

    void Update() 
    {
      OpenChest();

        if (GameManager_script.Finished == true)
        {
            Open = true;
        }
    }

    public void OpenChest()
    {
        if (Open == true) {

            chestAnimation.SetBool("Open", true);
        
        
        }
    }
}
