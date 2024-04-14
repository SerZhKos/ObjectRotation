using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectViewer : MonoBehaviour
{
    [SerializeField] private InputAction pressed, axis;

    private Transform cam;
    private new Renderer renderer;

    [SerializeField] private float speed = 1f;
    [SerializeField] private bool invered;
    public Transform objectToRotate;
    public ObjectViewerSettings objectSettings;

    private Camera ZoomCamera;

    private Vector2 rotation;

    private bool rotateAllowed;

    private void Start()
    {
        ZoomCamera = Camera.main;
        renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        float rotationSpeed = objectSettings.rotationSpeed;
        float zoomSpeed = objectSettings.zoomSpeed;
        float selectionDistance = objectSettings.selectionDistance;
        if (ZoomCamera.orthographic)
        {
            ZoomCamera.orthographicSize -= Input.GetAxis("Mouse ScrillWheel") * zoomSpeed;
        }
        else
        {
            ZoomCamera.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        }
    }
    private void Awake()
    {
        cam = Camera.main.transform;
        pressed.Enable();
        axis.Enable();
        pressed.performed += _ => { StartCoroutine(Rotate()); };
        pressed.canceled += _ => { rotateAllowed = false; };
        axis.performed += context => { rotation = context.ReadValue<Vector2>(); };
    }

    private IEnumerator Rotate()
    {
        rotateAllowed = true;
        while (rotateAllowed)
        {
            rotation *= speed;
            transform.Rotate(Vector3.up * (invered? 1: -1), rotation.x, Space.World);
            transform.Rotate(cam.right * (invered? -1: 1), rotation.y, Space.World);
            yield return null;
        }
    }
}
