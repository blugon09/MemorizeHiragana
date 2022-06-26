using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static Hiragana;

public class InputAnswer : MonoBehaviour {

    public TMP_InputField inputText;

    public TextMeshProUGUI problem;
    public TextMeshProUGUI score;
    public AudioSource dingSound;

    public void OnEndEdit() {
        if(HiraganaMap()[problem.text] == inputText.text) {
            GameObject.Find("Empty").GetComponent<OnStart>().nowScore.score++;
            score.text = "Score : " + GameObject.Find("Empty").GetComponent<OnStart>().nowScore.score;
            StopCoroutine(GameObject.Find("Empty").GetComponent<OnStart>().problemCoroutine);
            GameObject.Find("Empty").GetComponent<OnStart>().problemCoroutine = StartCoroutine(GameObject.Find("Empty").GetComponent<OnStart>().Problem());
            dingSound.time = 0.1338f;
            dingSound.Play();
        } else {
        }
        inputText.text = "";
    }

    void Start() {
        
    }

    void Update() {
        
    }
}
