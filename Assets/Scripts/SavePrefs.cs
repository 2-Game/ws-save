using UnityEngine;
using UnityEngine.UI;

public class SavePrefs : MonoBehaviour
{
    [SerializeField]
    private Slider volumeSlider = null;

    [SerializeField]
    private Text volumeTextUI = null;

    private void Start()
    {
        LoadValues();
    }

    public void VolumeSlider(float volume)
    {
        volumeTextUI.text = volume.ToString("0.0");
    }

    public void SaveVolumePrefs()
    {
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        Debug.Log(volumeValue);
    }

    void LoadValues()
    {
        float volumeValue = PlayerPrefs.GetFloat("volumeValue");
        volumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
}
