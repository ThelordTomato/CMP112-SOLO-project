using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickForPuzzle2 : MonoBehaviour
{
    public Transform Player;
    public float Range = 2f;


    void OnMouseDown()
    {

        float distance = Vector2.Distance(Player.position, transform.position);

        if (distance <= Range)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("ChessPuzzle");
        }

        



    }
   

    
}
