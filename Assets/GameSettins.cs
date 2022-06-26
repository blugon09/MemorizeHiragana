using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using static Settings;

public class GameSettins : MonoBehaviour {

    public AudioSource audio;

    // Start is called before the first frame update
    void Start() {
        if(!(new FileInfo(Application.dataPath + "/settings.json")).Exists) {
            Settings settings = new Settings();
            settings.musicVolume = 0.5f;
            settings.timeLimit = 3;

            settings.saveJson();
        }
        Settings setting = GetSettings();
        audio.volume = setting.musicVolume;
    }

    // Update is called once per frame
    void Update() {
        
    }
}