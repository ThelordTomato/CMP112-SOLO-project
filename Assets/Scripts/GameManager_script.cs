//Used https://www.youtube.com/watch?v=IgBjJ-bexeo to help make game

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager_script : MonoBehaviour
{

    //gets the Transformation of both the game board and gamepiece
    [SerializeField] private Transform gameTransform;
    [SerializeField] private Transform gamepiece;

    private List<Transform> pieces;
    private int emptyLocation;
    private int Size;

    private void CreatePieces(float gapThickness)
    {
        float width = 1 / (float)Size;

        //makes a split tile for each row and column -1 so it can move 
        for (int row = 0; row < Size; row++)
        {
            for (int col = 0; col < Size; col++)
            {
                Transform piece = Instantiate(gamepiece, gameTransform);
                pieces.Add(piece);

                // Center tile in the grid 
                piece.localPosition = new Vector3(-1f + width * (col + 0.5f), 1f - width * (row + 0.5f), 0f);

                piece.localScale = (width - gapThickness) * Vector3.one;
                piece.name = $"{row * Size + col}";

                //takes out the last tile
                if (row == Size - 1 && col == Size - 1)
                {
                    emptyLocation = Size * Size - 1;
                    piece.gameObject.SetActive(false);
                }
                else
                {
                    // Apply UV mapping for this tile
                    float gap = gapThickness / 2f;
                    Mesh mesh = piece.GetComponent<MeshFilter>().mesh;
                    Vector2[] uv = new Vector2[4];

                    // bottom-left
                    uv[0] = new Vector2((width * col) + gap, 1 - (width * (row + 1)) + gap);
                    // bottom-right
                    uv[1] = new Vector2((width * (col + 1)) - gap, 1 - (width * (row + 1)) + gap);
                    // top-left
                    uv[2] = new Vector2((width * col) + gap, 1 - (width * row) - gap);
                    // top-right
                    uv[3] = new Vector2((width * (col + 1)) - gap, 1 - (width * row) - gap);

                    mesh.uv = uv;
                }
            }
        }
    }

    void Start()
    {
        
        //decides how many rows and columns there will be
        Size = 3;

        // makes a list of transformations
        pieces = new List<Transform>();

        CreatePieces(0.01f);
        shuffle();
    }

    void Update()
    {
        movement();

    }



    void movement()
    {
        //checks it left click has been pressed
        if (Input.GetMouseButtonDown(0)) {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D click = Physics2D.OverlapPoint(mousePos);


            if (click == null) return;

            //repeats for each viable angle
            for (int i = 0; i < pieces.Count; i++) {
                if (pieces[i] == click.transform) {
                    if (Swap_Valid(i, -Size, Size)) { break; }
                    if (Swap_Valid(i, Size, -Size)) { break; }
                    if (Swap_Valid(i, -1, 0)) { break; }
                    if (Swap_Valid(i, +1, Size - 1)) { break; }



                }
            }
        }
    }

    bool Swap_Valid(int i, int offset, int colCheck)
    {

        //colCheck will make sure that its not on an edge and unmoveable to swap (aka 2 and 3 should never be able to switch cause there opposite sides)
        if (((i % Size) != colCheck) && ((i + offset) == emptyLocation)) {

            (pieces[i], pieces[i + offset]) = (pieces[i + offset], pieces[i]);
            //swaps there positions 
            (pieces[i].localPosition, pieces[i + offset].localPosition) = ((pieces[i + offset].localPosition, pieces[i].localPosition));
            //Update Empty Location
            emptyLocation = i;
            return true;

        }
        return false;
    }

    void shuffle()
    {
        // very own brute force shuffler

        System.Random rand = new System.Random();
        int ranNum = Random.Range(100, 1001);

        //makes a random amount of shuffles from 100 to 1000
        for (int J = 0; J < ranNum; J++)
        {
            //chooses a random num from 0 to the amount of pieces and will swap if its valid 
           int i = Random.Range(0, pieces.Count);

            if (Swap_Valid(i, -Size, Size)) { continue; }
            if (Swap_Valid(i, Size, -Size)) { continue; }
            if (Swap_Valid(i, -1, 0)) { continue; }
            if (Swap_Valid(i, +1, Size - 1)) { continue; }

        }


        bool Complete()
        {
            //starts loop for piece Count where itll check if all the names are in the right order
            for (int i = 0; i < pieces.Count; i++) 
            {
                //returns false if not
                if (pieces[i].name != $"{i}")
                {
                    return false;
                }
            }

            return true;
        }


    }
}