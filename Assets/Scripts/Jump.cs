using UnityEngine;

public class Jump : MonoBehaviour
{
    public float Gravity;
    public bool CanJump = true;
    public float Thrust;
    Rigidbody rb;


    void Start()
    {
        //getting rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        JumpMovement();

    }


    private void JumpMovement()
    {
        //line makes it so if you press jump and are touching the floor you can jump
        if (Input.GetKey(KeyCode.Space) && CanJump == true)
        {

            rb.AddForce(0, Thrust, 0, ForceMode.Impulse);
            //sets it to say you are off the floor
            CanJump = false;
        }
        if (CanJump == false)
        {
            //when off the floor this gives you more gravity so jumps feel less spacelike
            rb.AddForce(Vector3.down* Gravity, ForceMode.Acceleration);

        }


    }

    void OnCollisionEnter(Collision collision)
    {
        // if touching the gameobject map which is what i called the floor canjump is set to true
        if (collision.gameObject.name == "Map")
        {
            CanJump = true;
            
        }
    }
}
