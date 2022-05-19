using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalRecharge : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "CrystalMeateore")
        {
            Debug.Log("charge");
        }
    }
}
