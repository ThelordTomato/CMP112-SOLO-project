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
        
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * SensitivityX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * SensitivityX;

        yAxis += mouseX;
        xAxis -= mouseY;

        transform.rotation = Quaternion.Euler(xAxis, yAxis, 0);
        orientation.rotation = Quaternion.Euler(0, yAxis, 0);
    }
}
