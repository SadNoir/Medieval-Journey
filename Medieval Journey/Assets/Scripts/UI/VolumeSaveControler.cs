using UnityEngine;
using UnityEngine.UI;

public class VolumeSaveControler : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private Text volumeTextUI = null;

    private void Start()
    {
        LoadValues();
    }

    private void Update()
    {
        
    }

    public void VolumeSlider(float volume)
    {
        volumeTextUI.text = volume.ToString("0,0");
    }

    public void SaveVolumeButton()
    {
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        LoadValues();
    }

    private void LoadValues()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        volumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
}
