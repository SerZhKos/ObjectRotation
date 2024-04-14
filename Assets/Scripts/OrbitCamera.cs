using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public Transform target;
    public ObjectViewerSettings objectSettings;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        float rotationSpeed = objectSettings.rotationSpeed;

        transform.RotateAround(target.position, Vector3.up, horizontalInput * rotationSpeed);

        transform.RotateAround(target.position, transform.right, verticalInput * rotationSpeed);
    }
}
