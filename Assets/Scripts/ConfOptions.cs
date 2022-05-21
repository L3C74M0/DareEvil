using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfOptions : MonoBehaviour {

    public OptionsController optionsController;

    void Start() {
        optionsController = GameObject.FindGameObjectWithTag("options").GetComponent<OptionsController>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            ShowOptions();
        }
    }

    public void ShowOptions() {
        optionsController.optionsScreen.SetActive(true);
    }
}
