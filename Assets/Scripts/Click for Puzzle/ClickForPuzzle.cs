using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickForPuzzle : MonoBehaviour
{
    public Transform Player;
    public float Range;


    //starts on click
    void OnMouseDown()
    {
        //it gets the position  between the player character and the objects position
        float distance = Vector2.Distance(Player.position, transform.position);

        //while the range is bigger than the distance between the player and object it will send the player to the specified scene
        if (distance <= Range)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("SlidingPuzzle");
        }

        



    }
   

    
}
