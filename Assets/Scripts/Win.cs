using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        //script to make you move to the victory screen
        if (collision.gameObject.CompareTag("Player") && DoorEnter.Complete == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("Win");
            


        }
    }
}
