using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    public GameObject confirmationPanel;
    void Start()
    {
        confirmationPanel.SetActive(false);
    }

    public void ShowConfirmationPanel()
    {
        confirmationPanel.SetActive(true);
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }

    public void CloseConfirmationPanel()
    {
        confirmationPanel.SetActive(false);
    }
}
