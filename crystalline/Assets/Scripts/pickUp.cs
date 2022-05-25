using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public bool pickedUp = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pickedUp = true;
            Debug.Log("touch");
            Destroy(gameObject);
        }
    }
}
