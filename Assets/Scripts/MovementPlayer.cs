//Used https://www.youtube.com/watch?v=f473C43s8nE to help make movement
//Didnt however use it to help with jumping

using UnityEngine;


public class MovementPlayer : MonoBehaviour
{
   
    //Initializing variables
    public float movespeed;
    public float DragFactor;


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
        Run();
        
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


        //used to move the ridgidbody 
        rb.AddForce(Move.normalized * movespeed * 10f, ForceMode.Force);

       
        Vector3 drag = new Vector3((-rb.linearVelocity.x * DragFactor),0,(-rb.linearVelocity.z * DragFactor));
        rb.AddForce(drag, ForceMode.Acceleration);




    }

    void Run()
    {
        //run mechanic
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movespeed = movespeed * 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movespeed = movespeed / 2;
        }
    }

   

}

