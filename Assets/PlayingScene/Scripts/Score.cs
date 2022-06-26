using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class Score {
    public int score = 0;

    public void saveScore() {
        string json = JsonUtility.ToJson(this);
        //Debug.Log(json);

        FileStream fileStream = new FileStream(Application.dataPath + "/bestScore.json", FileMode.Create);
        byte[] data = Encoding.UTF8.GetBytes(json);
        fileStream.Write(data, 0, data.Length);
        fileStream.Close();
    }

    public static Score GetBestScore() {
        if(!(new FileInfo(Application.dataPath + "/bestScore.json")).Exists) {
            Score newScore = new Score();
            newScore.score = 0;
            return newScore;
        }
        FileStream fileStream = new FileStream(Application.dataPath + "/bestScore.json", FileMode.Open);
        byte[] data = new byte[fileStream.Length];
        fileStream.Read(data, 0, data.Length);
        fileStream.Close();
        string json = Encoding.UTF8.GetString(data);
        Score score = JsonUtility.FromJson<Score>(json);
        return score;
    }

    public bool isBestScore() {
        Score bestScore = GetBestScore();
        if (bestScore.score < score) {
            return true;
        } else {
            return false;
        }
    }
}
