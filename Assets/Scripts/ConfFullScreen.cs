using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConfFullScreen : MonoBehaviour {
    
    public Toggle toggle;
    public TMP_Dropdown resolution;
    Resolution[] resolutions;
    
    void Start() {
        if (Screen.fullScreen) {
            toggle.isOn = true;
        } else {
            toggle.isOn = false;
        }

        CheckResolution();
    }
    
    void Update() {
        
    }

    public void PutFullScreen (bool fullScreen) {
        Screen.fullScreen = fullScreen;
    }

    public void CheckResolution() {
        resolutions = Screen.resolutions;
        resolution.ClearOptions();
        List<string> options = new List<string>();
        int currentResolution = 0;

        for (int i = 0; i < resolutions.Length; i++) {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (Screen.fullScreen && resolutions[i].width == Screen.currentResolution.width && 
                resolutions[i].height == Screen.currentResolution.height) {
                currentResolution = i;
            }
        }

        resolution.AddOptions(options);
        resolution.value = currentResolution;
        resolution.RefreshShownValue();

        resolution.value = PlayerPrefs.GetInt("numResolution", 0);
    }

    public void ChangueResolution(int indexResolution) {
        PlayerPrefs.SetInt("numResolution", this.resolution.value);
        Resolution resolution = resolutions[indexResolution];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
