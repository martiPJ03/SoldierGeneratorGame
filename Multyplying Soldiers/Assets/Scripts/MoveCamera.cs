using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float cameraSpeed = 5f;  // Speed of camera movement
    private float screenWidth;

    void Start()
    {
        // Get the screen width
        screenWidth = Screen.width;
    }

    void Update()
    {
        // Check for touches
        if (Input.touchCount > 0 )
        {
            // Get the first touch
            Touch touch = Input.GetTouch(0);

            // If the touch is on the right side of the screen
            if (touch.position.x > screenWidth / 2 && transform.position.x < 6f)
            {
                MoveCameraDirection(Vector3.right);
            }
            // If the touch is on the left side of the screen
            else if (touch.position.x < screenWidth / 2 && transform.position.x > -6f)
            {
                MoveCameraDirection(Vector3.left);
            }
        }
        
        
        if (Input.GetKey(KeyCode.D) && transform.position.x < 6f)
        {
            MoveCameraDirection(Vector3.right);
        }
        else if (Input.GetKey(KeyCode.A) && transform.position.x > -6f)
        {
            MoveCameraDirection(Vector3.left);
        }
        
        
    }

    void MoveCameraDirection(Vector3 direction)
    {
        // Move the camera in the direction
        transform.Translate(direction * cameraSpeed * Time.deltaTime);
    }
}
