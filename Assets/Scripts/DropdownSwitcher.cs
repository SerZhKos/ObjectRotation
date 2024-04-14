using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownSwitcher : MonoBehaviour
{
    public Dropdown dropdownMenu;
    public GameObject[] objectParts;

    private void Start()
    {
        List<string> objectNames = new List<string>();
        foreach (GameObject obj in objectParts)
        {
            objectNames.Add(obj.name);
        }

        dropdownMenu.AddOptions(objectNames);
        dropdownMenu.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    public void OnDropdownValueChanged(int index)
    {
        for (int i = 0; i < objectParts.Length; i++)
        {
            if (i == index)
            {
                objectParts[i].SetActive(true);
            }
            else
            {
                objectParts[i].SetActive(false);
            }
        }
    }
}
