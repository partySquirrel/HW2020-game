using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugDeath : MonoBehaviour
{
    public Animator animator;
    public WalkToTarget walkToTarget;
    public float timeToFade;
    public AudioSource deathSound;

    private float timer = 0.0f;
    private bool isDead = false;


    void OnMouseDown()
	{
        if(!enabled) {
            return;
        }

        isDead = true;
        animator.SetTrigger("isDead");
        walkToTarget.enabled = false;
        deathSound.Play();
        
	}

    void Update() 
    {
        if(isDead) {
            timer += Time.deltaTime;

            if (timer > timeToFade) {
                Destroy(gameObject);
            }
        }
    }
}
