using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private Quaternion initialRotation;
    public GameObject objectToReset;
    public Vector3 initialPosition;
    public Camera mainCamera;
    public GameObject uiPanel;

    private bool objectWasVisible;
    private Vector3 cameraOffset;

    private void Start()
    {
        initialPosition = objectToReset.transform.position;
        objectToReset.transform.rotation = initialRotation;
        objectWasVisible = objectToReset.activeSelf;
        cameraOffset = mainCamera.transform.position - objectToReset.transform.position;
    }

    public void ResetObject()
    {
        objectToReset.transform.position = initialPosition;
        objectToReset.transform.rotation = initialRotation;
        mainCamera.transform.position = objectToReset.transform.position + cameraOffset;
        mainCamera.transform.LookAt(objectToReset.transform); // Направляем камеру на объект
        uiPanel.SetActive(false);

        if (!objectWasVisible)
        {
            objectToReset.SetActive(true);
        }
    }
}
