using UnityEngine;
using UnityEngine.SceneManagement;

public class Enter : MonoBehaviour
{
    public Num1 button;
    public static bool Done;
    private AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }


    void OnMouseDown()
    {

        if (button.sequence == 3)
        {

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            SceneManager.LoadScene("play");
            Done = true;


        }


        sound.Play();



    }
    void Update()
    {
        Quit();

    }

    void Quit()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            SceneManager.LoadScene("play");
            button.sequence = 0;
        }

    }
}