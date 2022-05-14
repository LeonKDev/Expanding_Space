using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalRotation : MonoBehaviour
{
    public GameObject center;
    public float radius = 2f;
    public float phi = 0f;
    public float dPhi = 0.01f;

    float x;
    float y;
    float z;

    // Update is called once per frame
    void Update()
    {
        x = radius * Mathf.Cos(phi);
        y = 0;
        z = radius * Mathf.Sin(phi);
        transform.position = new Vector3(x, y, z) + center.transform.position;

        phi -= dPhi * Time.deltaTime;
    }
}