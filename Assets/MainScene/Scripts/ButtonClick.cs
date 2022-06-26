using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Text;

public class ButtonClick : MonoBehaviour {

    public GameObject mainScreen;
    public GameObject settingsScreen;
    public GameObject creditScreen;
    public GameObject hiraganaScreen;
    public AudioSource audio;

    public void SettingsButton() {
        mainScreen.SetActive(false);
        settingsScreen.SetActive(true);
    }

    public void BackButton() {
        mainScreen.SetActive(true);
        settingsScreen.SetActive(false);
        creditScreen.SetActive(false);
        hiraganaScreen.SetActive(false);
    }

    public void StartButton() {
        string json = "{ \"musictime\": \"" + audio.time + "\" }";
        FileStream fileStream = new FileStream(Application.dataPath + "/musictime.json", FileMode.Create);
        byte[] data = Encoding.UTF8.GetBytes(json);
        fileStream.Write(data, 0, data.Length);
        fileStream.Close();

        SceneManager.LoadScene("PlayingScene");
    }

    public void CreditButton() {
        mainScreen.SetActive(false);
        creditScreen.SetActive(true);
    }

    public void HiraganaButton() {
        mainScreen.SetActive(false);
        hiraganaScreen.SetActive(true);
    }
}
