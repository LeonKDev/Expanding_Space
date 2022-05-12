using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalInteraction : MonoBehaviour
{
    public GameObject CrystalActivePrefab;
    public GameObject spawnPositions;




    void Update()
    {

        if (Input.GetKeyDown(KeyCode.X))
        {
            GameObject crystal = Instantiate(CrystalActivePrefab, spawnPositions.transform.position, CrystalActivePrefab.transform.localRotation);
            Destroy(gameObject);
            
        }

    }
}