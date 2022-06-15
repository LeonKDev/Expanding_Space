using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation: MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetFloat("speed", 0.01f);
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetFloat("speed", -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetFloat("speed", 1);
        }
    }
}