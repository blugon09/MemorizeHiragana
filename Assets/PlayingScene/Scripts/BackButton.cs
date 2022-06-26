using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Text;

public class BackButton : MonoBehaviour {

    public void BackMainButton() {
        SceneManager.LoadScene("MainScene");
    }
}
