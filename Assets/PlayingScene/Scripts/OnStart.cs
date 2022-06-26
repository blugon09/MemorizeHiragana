using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using System.Threading;
using TMPro;
using static MusicTime;
using static Settings;
using static Hiragana;
using static Score;

public class OnStart : MonoBehaviour {

    public AudioSource audio;
    public TextMeshProUGUI countdown;
    public GameObject countdownObject;
    public GameObject playingGroup;
    public GameObject gameOverGroup;

    public TextMeshProUGUI problem;
    public TextMeshProUGUI score;
    public TextMeshProUGUI timeLimit;
    public TMP_InputField inputText;

    public TextMeshProUGUI gameOverText;
    public GameObject gameOverBestScore;
    public TextMeshProUGUI gameOverScore;

    public Score nowScore = new Score();
    
    public Coroutine problemCoroutine;

    void Start() {
        FileStream fileStream = new FileStream(Application.dataPath + "/musictime.json", FileMode.Open);
        byte[] data = new byte[fileStream.Length];
        fileStream.Read(data, 0, data.Length);
        fileStream.Close();
        string json = Encoding.UTF8.GetString(data);
        MusicTime musictime = JsonUtility.FromJson<MusicTime>(json);

        if (!(new FileInfo(Application.dataPath + "/settings.json")).Exists) {
            Settings settings = new Settings();
            settings.musicVolume = 0.5f;
            settings.timeLimit = 3;

            settings.saveJson();
        }
        Settings setting = GetSettings();

        audio.time = musictime.musictime;
        audio.volume = setting.musicVolume;
        audio.Play();
        nowScore.score = 0;
        score.text = "Score : 0";

        StartCoroutine(CountDown());
    }


    IEnumerator CountDown() {
        yield return new WaitForSeconds(2);
        countdown.text = "3";
        yield return new WaitForSeconds(1);
        countdown.text = "2";
        yield return new WaitForSeconds(1);
        countdown.text = "1";
        yield return new WaitForSeconds(1);

        countdownObject.SetActive(false);
        playingGroup.SetActive(true);

        problemCoroutine = StartCoroutine(Problem());
    }

    public IEnumerator Problem() {
        Settings setting = GetSettings();
        while (true) {
            string newProblem = RandomHiragana();
            if (problem.text == newProblem) {
                continue;
            } else {
                problem.text = newProblem;
                break;
            }
        }
        for (int i = setting.timeLimit; i != -1; i--) {
            timeLimit.text = i + "";
            if(i == 0) {
                //StartCoroutine(GameOver());
                GameOver();
            }
            yield return new WaitForSeconds(1);
        }
    }

    void GameOver() {
        playingGroup.SetActive(false);
        gameOverGroup.SetActive(true);
        gameOverScore.text = score.text;
        gameOverText.text = "GAME OVER : "+HiraganaMap()[problem.text];
        if(nowScore.isBestScore()) {
            nowScore.saveScore();
            gameOverBestScore.SetActive(true);
        }
    }


    void Update() {
        inputText.ActivateInputField();
    }
}
