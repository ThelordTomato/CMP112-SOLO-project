using UnityEngine;

public class GameRender : MonoBehaviour
{
    [SerializeField] private Transform GameTransform;
    [SerializeField] private Transform gamepiece;
    [SerializeField] private Sprite[] GameSprite;

    private int EmptyLocation;
    private int Size;
    private int SpriteNum;


    void Start()
    {
        Size = 3;
        ShowUP(0.01f);
    }





    void ShowUP(float gapThickness)
    {


        float width = 2f / (float)Size;
        for (int row = 0; row < Size; row++) {
            for (int col = 0; col < Size; col++) {

                Transform piece = Instantiate(gamepiece, GameTransform);
                SpriteRenderer sr = piece.GetComponent<SpriteRenderer>();
                sr.sprite = GameSprite[SpriteNum];

                piece.localPosition = new Vector3(-1 + (width * col), 1 - (width * row), 0);

                piece.localScale = (width - gapThickness) * Vector3.one;

                piece.name = $"{(row * Size) + col}";
                
                if (row == Size - 1 && col == Size - 1)
                {
                    EmptyLocation = SpriteNum;
                    piece.gameObject.SetActive(false);
                }


                SpriteNum++;

            }
        }
    }









    void Update()
    {
        
    }
}
