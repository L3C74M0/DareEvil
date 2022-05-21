using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfBetweenScenes : MonoBehaviour {
    
    private void Awake() {
        var dontDestroyBetweenScenes = FindObjectsOfType<ConfBetweenScenes>();
        if (dontDestroyBetweenScenes.Length > 1) {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start() {
        
    }

    void Update() {
        
    }
}
