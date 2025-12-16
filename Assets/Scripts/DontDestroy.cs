using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



    public class DontDestroy : MonoBehaviour
{

    public static DontDestroy On;
    public GameObject Object;

    //keeps the Object alive no matter what screen

    void Awake()
    {
        if (On == null)
        {
            DontDestroyOnLoad(gameObject);
            On = this;
        }
        //makes sure you dont make multiple copies
        else if (On != this)
        {
            Destroy(gameObject);
        }
    }
}
