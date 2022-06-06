using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    
    public Text time;
    public static bool saved = false;

    void Start() {
        saved = false;
    }

    void Update() {
        if (ScoringSystem.theScore == 50) {
            PlayerPrefs.SetString("currentTime", time.text);
            saved = true;
            // I compare my time with the Tenth
            if (1 == time.text.CompareTo(PlayerPrefs.GetString("10T"))) {
                //Im Bigger, So I can save my Nick
                SceneSwitcher.OpenScene(2);
            } else {
                //Im Lower, So I can't save my Nick
                SceneSwitcher.OpenScene(1);
            }
        }
    }
}
