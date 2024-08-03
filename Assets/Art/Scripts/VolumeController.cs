using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VolumeController : MonoBehaviour
{
    public Slider volumeSlider; // Assign the slider in the Inspector
    public AudioSource audioSource; // Assign the audio source in the Inspector

    void Start()
    {
        if (volumeSlider != null && audioSource != null)
        {
            // Set the initial slider value to the current volume
            volumeSlider.value = audioSource.volume;

            // Add a listener to call the method when the slider value changes
            volumeSlider.onValueChanged.AddListener(delegate { AdjustVolume(); });
        }
    }

    public void AdjustVolume()
    {
        if (audioSource != null && volumeSlider != null)
        {
            // Adjust the volume of the audio source
            audioSource.volume = volumeSlider.value;
        }
    }
}
