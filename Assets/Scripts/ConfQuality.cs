using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConfQuality : MonoBehaviour {

    public TMP_Dropdown dropdown;
    public int quality;

    void Start() {
        quality = PlayerPrefs.GetInt("quality", 4);
        dropdown.value = quality;
        AdjustQuality();
    }

    void Update() {
        
    }

    public void AdjustQuality() {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("quality", dropdown.value);
        quality = dropdown.value;
    }
}
