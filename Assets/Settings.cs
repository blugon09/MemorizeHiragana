using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class Settings {
    public float musicVolume = 0.5f;
    public byte timeLimit = 3;

    public void saveJson() {
        string json = JsonUtility.ToJson(this);
        //Debug.Log(json);

        FileStream fileStream = new FileStream(Application.dataPath + "/settings.json", FileMode.Create);
        byte[] data = Encoding.UTF8.GetBytes(json);
        fileStream.Write(data, 0, data.Length);
        fileStream.Close();
    }

    public static Settings GetSettings() {
        FileStream fileStream = new FileStream(Application.dataPath + "/settings.json", FileMode.Open);
        byte[] data = new byte[fileStream.Length];
        fileStream.Read(data, 0, data.Length);
        fileStream.Close();
        string json = Encoding.UTF8.GetString(data);
        Settings settings = JsonUtility.FromJson<Settings>(json);
        return settings;
    }
}
