using UnityEngine;

public class LosingMove : MonoBehaviour
{
    private Vector3 OriginalPosition;
    private BoxCollider2D Piece;
    public static bool Completed = false;

    void Start()
    {
        Piece = GetComponent<BoxCollider2D>();

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

        transform.position = OriginalPosition;
    }
}

 
