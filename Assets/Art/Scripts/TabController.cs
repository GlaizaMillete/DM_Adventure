using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabController : MonoBehaviour
{
    public GameObject audioPanel;
    public GameObject achievementsPanel;
    public GameObject languagePanel;

    public Button audioTabButton;
    public Button achievementsTabButton;
    public Button languageTabButton;

    void Start()
    {
        // Add listeners to the buttons
        audioTabButton.onClick.AddListener(ShowAudioPanel);
        achievementsTabButton.onClick.AddListener(ShowAchievementsPanel);
        languageTabButton.onClick.AddListener(ShowLanguagePanel);

        // Show the default panel (audio)
        ShowAudioPanel();
    }

    void ShowAudioPanel()
    {
        audioPanel.SetActive(true);
        achievementsPanel.SetActive(false);
        languagePanel.SetActive(false);
    }

    void ShowAchievementsPanel()
    {
        audioPanel.SetActive(false);
        achievementsPanel.SetActive(true);
        languagePanel.SetActive(false);
    }

    void ShowLanguagePanel()
    {
        audioPanel.SetActive(false);
        achievementsPanel.SetActive(false);
        languagePanel.SetActive(true);
    }
}
