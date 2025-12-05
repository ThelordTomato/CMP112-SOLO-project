using UnityEngine;

public class Jump : MonoBehaviour
{
    public float Gravity;
    public bool CanJump = true;
    public float Thrust;
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        JumpMovement();

    }


    private void JumpMovement()
    {
        if (Input.GetKey(KeyCode.Space) && CanJump == true)
        {

            rb.AddForce(0, Thrust, 0, ForceMode.Impulse);
            CanJump = false;
        }
        if (CanJump == false)
        {
            
            rb.AddForce(Vector3.down* Gravity, ForceMode.Acceleration);

        }


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Map")
        {
            CanJump = true;
            
        }
    }
}
