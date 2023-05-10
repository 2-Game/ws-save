using UnityEngine;
using UnityEngine.UI;

public class VolumeControler : MonoBehaviour
{
    [SerializeField] public int currentVolume;
    public Text currentVolumeText;
    public Slider volumeSlider;

    void Start()
    {
        currentVolume = 80;
        volumeSlider.value = currentVolume;
        currentVolumeText.text = volumeSlider.value.ToString();
    }

    void Update()
    {
        currentVolumeText.text = volumeSlider.value.ToString();
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }


    public void Load()
    {
        PlayerPrefs.GetInt("Volume");
    }

    public void Save()
    {
        PlayerPrefs.SetInt("Volume", currentVolume);
    }
}
