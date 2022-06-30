using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_siren : MonoBehaviour
{
    public GameObject siren;
    public GameObject Death;
    public Animator animator;
    float prevSpeed;
    private float floating = 1f;


    void Start()
    {
        prevSpeed = animator.speed;
        animator.speed = 1;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject.GetComponent<movement>());
            animator.SetBool("scratch", true);
            animator.Play("Enemy_01_Animation_Attack");
            other.gameObject.SetActive(false);
            animator.SetBool("scratch", false);
            StartCoroutine(DeathScreen());

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "light")
        {
            prevSpeed = animator.speed;
            animator.speed = 0;
            StartCoroutine(timer());
        }
    }

    private IEnumerator timer()
    {
        yield return new WaitForSeconds(3);
        prevSpeed = animator.speed;
        animator.speed = 1;
    }

    IEnumerator DeathScreen()
    {

        yield return new WaitForSeconds(2f);
        Death.SetActive(true);
    }

}
