using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingsButtonHandler : MonoBehaviour
{
    public GameObject settingsPanel;

    public void OnButtonClick()
    {
        Debug.Log("Button Clicked");
        // Assuming OpenSettings() is the method to open the settings panel
        OpenSettings();
    }

    private void Start()
    {
        // Ensure the button is enabled at the start
        GetComponent<Button>().interactable = true;
    }

    public void OpenSettings()
    {
        Debug.Log("Opening settings panel");
        // Your existing logic to open the settings panel
    }
}
