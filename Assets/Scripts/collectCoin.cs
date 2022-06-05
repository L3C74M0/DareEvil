using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour {
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other) {
        collectSound.Play();
        ScoringSystem.theScore += 50;
        gameObject.SetActive(false);
    }
}
