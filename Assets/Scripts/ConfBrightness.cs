using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfBrightness : MonoBehaviour  {
    public Slider slider;
    public float sliderValue;
    public Image brightness;
    
    void Start() {
        slider.value = PlayerPrefs.GetFloat("brightness", 0.5f);
        brightness.color = new Color(brightness.color.r, brightness.color.g, brightness.color.b, slider.value);
    }

    void Update() {
    }

    public void ChangueSlider(float value) {
        sliderValue = value;
        PlayerPrefs.SetFloat("brightness", sliderValue);
        brightness.color = new Color(brightness.color.r, brightness.color.g, brightness.color.b, slider.value);
    }
}
