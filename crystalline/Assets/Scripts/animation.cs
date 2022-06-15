using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation: MonoBehaviour
{
    movement Movement;
    public GameObject Player;
    public Animator animator;

    private void Awake()
    {
        Movement = Player.GetComponent<movement>();
    }

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetFloat("speed", 0.01f);
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetFloat("speed", 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetFloat("speed", 1);
        }
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.A)))
        {
            animator.SetFloat("speed", 2);
        }

        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.D)))
        {
            animator.SetFloat("speed", 2);
        }
        if (Input.GetKey(KeyCode.Space) && Movement.canJump == true)
        {
            animator.SetBool("jump", true);
        }
        if (Movement.canJump == false)
        {
            animator.SetBool("jump", false);
        }
    }
}