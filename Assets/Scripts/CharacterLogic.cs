using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class CharacterLogic : MonoBehaviour {
    
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    private Animator animator;
    public float x, y;

    public GameObject gameOver;

    void Start() {
        animator = GetComponent<Animator>();
        ScoringSystem.theScore = 0;
    }

    void Update() {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * movementSpeed);

        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);
    }

    void OnTriggerEnter(Collider collider) {
        if (collider.CompareTag("blade")) {
            gameOver.SetActive(true);
            Other();
        }
    }

    protected async void Other() {
        await Task.Delay(3000);
        SceneSwitcher.OpenScene(1);
        await Task.Delay(100);
    }
}
