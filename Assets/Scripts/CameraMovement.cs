//Used https://www.youtube.com/watch?v=f473C43s8nE to help make movement
using UnityEngine;

public class CameraMovement : MonoBehaviour
{


    public Transform cameraPosition;

    // Update is called once per frame
    void Update()
    {
        
        transform.position = cameraPosition.position;

    }
}
