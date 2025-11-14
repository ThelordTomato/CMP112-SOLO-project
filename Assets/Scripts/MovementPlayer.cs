using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
   
    //Initializing variables
    public float movespeed;

    float horizontalInput;
    float verticalInput;

    public float Thrust;
    public Transform orientation;

    Vector3 Move;

    Rigidbody rb;
   

    void Start()
    {
        //getting the rigidbody of the player
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        MyInput();
    }

    void FixedUpdate()
    {

        MovePlayer();

    }


    private void MyInput()
    {
        //checks if input is horizontal & or vertical
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }




    void MovePlayer()
    {
        //calc Which way to move
        Move = (orientation.forward * verticalInput) + (orientation.right * horizontalInput);

        rb.AddForce(Move.normalized * movespeed * 10f, ForceMode.Force);

      
    }

}

