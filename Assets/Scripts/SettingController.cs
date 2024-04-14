using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class SettingController : MonoBehaviour
{
    public GameObject confirmationPanel;
    public Toggle fullscreenToggle;
    public Slider distanceSlider;
    public Slider speedSlider;
    public Slider rotationSlider;
    public Dropdown qualityDropdown;
    void Start()
    {
        confirmationPanel.SetActive(false);
        LoadSettings();
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetInt("Fullscreen", fullscreenToggle.isOn ? 1 : 0);
        PlayerPrefs.SetFloat("Distance", distanceSlider.value);
        PlayerPrefs.SetFloat("Speed", speedSlider.value);
        PlayerPrefs.SetFloat("Rotation", rotationSlider.value);
        PlayerPrefs.SetInt("Quality", qualityDropdown.value);

        PlayerPrefs.Save();
    }

    public void LoadSettings()
    {
        fullscreenToggle.isOn = PlayerPrefs.GetInt("Fullscreen", 1) == 1 ? true : false;
        distanceSlider.value = PlayerPrefs.GetFloat("Distance", 5f);
        speedSlider.value = PlayerPrefs.GetFloat("Speed", 1f);
        rotationSlider.value = PlayerPrefs.GetFloat("Rotation", 1f);
        qualityDropdown.value = PlayerPrefs.GetInt("Quality", 2);
    }

    public void ApplySettings()
    {
        Screen.fullScreen = fullscreenToggle.isOn;
        // Применение остальных настроек к вашим объектам
    }
    public void ShowConfirmationPanel()
    {
        confirmationPanel.SetActive(true);
    }

    public void CloseConfirmationPanel()
    {
        confirmationPanel.SetActive(false);
    }
}
