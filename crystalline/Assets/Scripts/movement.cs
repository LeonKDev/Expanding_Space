using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    private Rigidbody rb;
    public float jumpPower = 8;
    public bool canJump = true;
    public float movementSpeed = 3;
    public float runningSpeed = 5;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movementSpeed = 10.0f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movementSpeed = 3f;
        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.position += new Vector3(-movementSpeed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.position += new Vector3(movementSpeed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {

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