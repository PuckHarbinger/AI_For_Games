using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sesX;
    public float sesY;

    public Transform orientation;

    float xRotation;
    float yRotation;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    private void Update()
    {
        // get mouse input
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sesX;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sesY;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // rotate cam and orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);

}
}
