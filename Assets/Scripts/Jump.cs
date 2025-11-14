using UnityEngine;

public class Jump : MonoBehaviour
{
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
        if (Input.GetKeyDown(KeyCode.Space) && CanJump == true)
        {

            rb.AddForce(0, Thrust, 0, ForceMode.VelocityChange);
            CanJump = false;
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
