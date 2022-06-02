using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalRecharge : MonoBehaviour
{
    public crystal Crystal;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Recharge")
        {
            Debug.Log("Recharge");
            Crystal.energy = 100;
        }
    }

    private void Start()
    {
        Debug.Log(Crystal.energy);
    }
}