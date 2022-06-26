using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static Settings;
using static Score;

public class OnGame : MonoBehaviour {

    public Slider volume;
    public Slider timeLimit;
    public TextMeshProUGUI bestScore;

    void Start() {
        Settings setting = GetSettings();
        volume.value = setting.musicVolume;
        timeLimit.value = setting.timeLimit;
        bestScore.text = "Best Score\n"+GetBestScore().score;
    }

    void Update() {

    }
}