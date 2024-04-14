using UnityEngine;

[CreateAssetMenu(fileName = "ObjectViewerSettings", menuName = "ScriptableObjects/ObjectViewerSettings", order = 1)]
public class ObjectViewerSettings : ScriptableObject
{
    public float rotationSpeed = 10f;
    public float zoomSpeed = 1f;
    public float selectionDistance = 10f;
}
