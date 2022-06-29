using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationFluffy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fluffy;
    public GameObject Death;
    public Animator animator;
    float prevSpeed;


    void Start()
    {
        prevSpeed = animator.speed;
        animator.speed = 1;
    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject.GetComponent<movement>());
            animator.Play("Fluffy_springen_Attack_ Animation");
            other.gameObject.SetActive(false);
            StartCoroutine(DeathAni());
            Death.SetActive(true);
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
    private IEnumerator DeathAni()
    {
        yield return new WaitForSeconds(2);
    }
}
