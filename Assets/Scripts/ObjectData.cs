using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectData", menuName = "ObjectData", order = 1)]
public class ObjectData : ScriptableObject
{
    public List<GameObject> parts = new List<GameObject>();
}
