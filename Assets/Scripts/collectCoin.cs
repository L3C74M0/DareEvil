using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectCoin : MonoBehaviour
{
     public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        scoringSystem.theScore += 50;
        Destroy(gameObject);
    }
}
