using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public bool pickedUp = false;
    public GameObject test;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item" && pickedUp == false)
        {

            pickedUp = true;
            Debug.Log("touch");
            Destroy(other.gameObject);
        }

        if (pickedUp == true)
        {
            test.SetActive(true);
        }
        else if (pickedUp == false)
        {
            test.SetActive(false);
        }
    }
}
