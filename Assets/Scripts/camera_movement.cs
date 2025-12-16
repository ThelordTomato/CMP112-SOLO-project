//Used https://www.youtube.com/watch?v=f473C43s8nE to help make movement
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class camera_movement : MonoBehaviour
{
    public float SensitivityX;
    public float SensitivityY;

    public Transform orientation;

    public float xAxis;
    public float yAxis;

    private void Start()
    {
        //locks mouse
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }


    
    void Update()
    {
        // gets the x and y of the mouse multiplied by the time and Sensitivity
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * SensitivityX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * SensitivityX;

        yAxis += mouseX;
        xAxis -= mouseY;

        //makes sure you cant just spin the camera 360 degrees and gives you 180 degrees up and down
        xAxis = Mathf.Clamp(xAxis, -90f, 90f);

        transform.rotation = Quaternion.Euler(xAxis, yAxis, 0);
        //makes sure the orientation only takes to Y axis
        orientation.rotation = Quaternion.Euler(0, yAxis, 0);
    }
}
