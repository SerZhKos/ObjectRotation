using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;

using System.Linq;
using TMPro;
using UnityEditor;

public class FileLoader : MonoBehaviour
{
    public InputField filePathInput;
    public Button loadButton;

    private string filePath;

    private void Start()
    {
        loadButton.onClick.AddListener(LoadFile);
    }

    public void LoadFile()
    {
        filePath = filePathInput.text;

        StartCoroutine(LoadFileCoroutine());
    }

    IEnumerator LoadFileCoroutine()
    {
        // ���������, ���������� �� ���� �� ���������� ����
        if (File.Exists(filePath))
        {
            // ������ ���������� �����
            using (StreamReader reader = new StreamReader(filePath))
            {
                string fileContents = reader.ReadToEnd();
                Debug.Log("���������� �����: " + fileContents);
            }
        }
        else
        {
            Debug.LogError("���� �� ������: " + filePath);
        }

        yield return null;
    }
}
