using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    public float jumpPower = 8;
    public bool canJump = true;
    public float movementSpeed = 3;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetFloat("Speed", 0);
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetFloat("Speed", 1);
            transform.position += new Vector3(-movementSpeed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetFloat("Speed", -1);
            transform.position += new Vector3(movementSpeed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.W) && canJump == true)
        {
            animator.SetTrigger("jump");
            rb.velocity = new Vector3(0, jumpPower, 0);
        }
        if (Input.GetKeyDown(KeyCode.S) && canJump == true)
        {

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        canJump = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        canJump = false;
    }
}
