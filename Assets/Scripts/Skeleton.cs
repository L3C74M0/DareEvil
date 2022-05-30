using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour {

    public int rutine;
    public float chronometer;
    public Animator animator;
    public Quaternion angle;
    public float degree;

    public GameObject target;
    public bool attacking;
    
    void Start() {
        animator = GetComponent<Animator>();
        target = GameObject.Find("erinys");
    }

    void Update() {
        EnemyBehavior();
    }

    public void EnemyBehavior() {
        if (Vector3.Distance(transform.position, target.transform.position) > 10) {
            animator.SetBool("run", false);
            chronometer += 1 * Time.deltaTime;
            if (chronometer >= 4) {
                rutine = Random.Range(0, 2);
                chronometer = 0;
            }

            switch (rutine) {
                case 0:
                    animator.SetBool("walk", false);
                    break;
                case 1:
                    degree = Random.Range(0, 360);
                    angle = Quaternion.Euler(0, degree, 0);
                    rutine++;
                    break;
                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angle, 0.5f);
                    transform.Translate(Vector3.forward * 1 * Time.deltaTime);
                    animator.SetBool("walk", true);
                    break;
            }
        } else {
            if (Vector3.Distance(transform.position, target.transform.position) > 1  && !attacking) {
                var lookPosition = target.transform.position - transform.position;
                lookPosition.y = 0;
                var rotation = Quaternion.LookRotation(lookPosition);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 3);
                animator.SetBool("walk", false);
                animator.SetBool("run", true);
                transform.Translate(Vector3.forward * 2 * Time.deltaTime);

                animator.SetBool("attack", false);
            } else {
                animator.SetBool("walk", false);
                animator.SetBool("run", false);
                animator.SetBool("attack", true);
                attacking = true;
            }
        }
    }

    public void EndingAnimation() {
        animator.SetBool("attack", false);
        attacking = false;
    }
}
