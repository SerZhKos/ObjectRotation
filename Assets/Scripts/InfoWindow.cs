using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoWindow : MonoBehaviour
{
    public GameObject infoPanel;
    public Text objectNameText;
    public Text objectDescriptionText;

    private string currentObjectName;
    private string currentObjectDescription;

    void Start()
    {
        infoPanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                GameObject hitObject = hit.collider.gameObject;

                if (hitObject.CompareTag("Object"))
                {
                    ObjectInfoData objectData = hitObject.GetComponent<ObjectInfoData>();
                    currentObjectName = hitObject.name;
                    currentObjectDescription = objectData.objectDescription;
                    DisplayObjectInfo();
                }
            }
        }
    }

    void DisplayObjectInfo()
    {
        infoPanel.SetActive(true);
        objectNameText.text = currentObjectName;
        objectDescriptionText.text = currentObjectDescription;
    }

    public void CloseInfoPanel()
    {
        infoPanel.SetActive(false);
    }
}
