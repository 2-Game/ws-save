using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
// using TMPro;

public class VolumeControler : MonoBehaviour
{
    [SerializeField] public float currentVolume;
    // [SerializeField] public float volumeMax = 100.0f;
    // public TextMeshProUGUI currentVolumeText;
    public Text currentVolumeText;
    public Slider volumeSlider;

    void Start()
    {
        currentVolume = 0.8f;
        // volumeSlider.value = currentVolume;
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }
}
