//for desc look at ClickForPuzzle

using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickForPuzzle3 : MonoBehaviour
{
    public Transform Player;
    public float Range;


    void OnMouseDown()
    {

        float distance = Vector2.Distance(Player.position, transform.position);

        if (distance <= Range)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("KeyPad_1");
        }

        



    }
   

    
}
