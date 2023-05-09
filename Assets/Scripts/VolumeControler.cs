using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
// using TMPro;

public class VolumeControler : MonoBehaviour
{
    [SerializeField] public float currentVolume;
    [SerializeField] public float volumeMax = 100.0f;
    // public TextMeshProUGUI currentVolumeText;
    public Text currentVolumeText;
    public Slider volumeSlider;

    void Start()
    {
        currentVolume = 80.0f;
        volumeSlider.value = currentVolume;
        volumeSlider.maxValue = volumeMax;
        
        volumeSlider.onValueChanged.AddListener(delegate {VolumeValueChange();});
    }

    // Update is called once per frame
    void Update()
    {
        VolumeValueChange();
        currentVolumeText.text = currentVolume.ToString();
    }

    public void VolumeValueChange()
    {
        Debug.Log(volumeSlider.value);
    }
}
