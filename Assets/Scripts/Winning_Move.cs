using UnityEngine;
using UnityEngine.SceneManagement;

public class Winning_Move : MonoBehaviour
{
    private Vector3 OriginalPosition;
    private BoxCollider2D Win;
    public BoxCollider2D DeadPawn;
    public static bool Completed = false;

    void Start()
    {
        Win = GetComponent<BoxCollider2D>();

    }


    void OnMouseDown()
    {
        OriginalPosition = transform.position;
    }

    void OnMouseDrag()
    {
        //gets mouse position
        Vector3 Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //sets queen to be at that position
        transform.position = new Vector3(Pos.x, Pos.y, transform.position.z);
    }

    void OnMouseUp()
    {
        if (Win.bounds.Intersects(DeadPawn.bounds))
        {

            DeadPawn.gameObject.SetActive(false);
            Completed = true;
            SceneManager.LoadScene("play");


    }
        else
        {

            transform.position = OriginalPosition;
        }

    }

}