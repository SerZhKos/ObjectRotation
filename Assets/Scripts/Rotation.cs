using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    public GameObject objectToRotate;

    public void ReverseRotation()
    {
        objectToRotate.transform.Rotate(0, 180, 0);
    }
}
