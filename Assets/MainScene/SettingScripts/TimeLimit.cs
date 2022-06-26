using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Settings;
using TMPro;

public class TimeLimit : MonoBehaviour {

    public Slider slider;
    public TextMeshProUGUI text;

    public void timeLimitSetting() {
        Settings setting = GetSettings();
        setting.timeLimit = (byte)slider.value;
        setting.saveJson();
        text.text = "" + setting.timeLimit;
    }
}
