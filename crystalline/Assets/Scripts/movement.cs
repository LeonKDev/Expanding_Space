using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class movement : MonoBehaviour
{
    public GameObject Player;
    private Rigidbody2D rb;
    public float jumpPower = 8;
    public bool canJump = true;
    public float movementSpeed;

    public float RotateValue1 = -1;
    public float RotateValue2 = 1;
    

    

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
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

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movementSpeed = 10.0f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movementSpeed = 5f;
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
    }
    private void ontriggerenter2D(Collision2D collision)
    {
        canJump = true;
    }
    private void OntriggerExit2D(Collision2D collision)
    {
        canJump = false;
    }


   

}