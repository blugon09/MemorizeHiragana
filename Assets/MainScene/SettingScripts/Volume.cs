using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Settings;
using TMPro;

public class Volume : MonoBehaviour {

    public Slider slider;
    public AudioSource audio;
    public TextMeshProUGUI text;

    public void volumeSetting() {
        audio.volume = slider.value;
        Settings setting = GetSettings();
        setting.musicVolume = slider.value;
        setting.saveJson();
        text.text = ((int)(slider.value*100))+"%";
    }
}
