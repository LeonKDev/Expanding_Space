using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    private Rigidbody rb;
    public float jumpPower = 8;
    public bool canJump = true;
    public float movementSpeed = 3;
    public float RotateValue1 = -1;
    public float RotateValue2 = 1;

    public GameObject Player;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") == RotateValue1)
        {
            Vector3 scale = Player.GetComponent<Transform>().localScale;
            Player.GetComponent<Transform>().localScale = new Vector3(-0.3f, scale.y, scale.z);
        }

        if (Input.GetAxisRaw("Horizontal") == RotateValue2)
        {
            Vector3 scale = Player.GetComponent<Transform>().localScale;
            Player.GetComponent<Transform>().localScale = new Vector3(0.3f, scale.y, scale.z);
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
