using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLogic : MonoBehaviour {
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    private Animator animator;
    public float x, y;



    void Start() {
        animator = GetComponent<Animator>();
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
            print("Damage");
        }
    }
}
