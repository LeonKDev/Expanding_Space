using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalInteraction : MonoBehaviour
{
    public GameObject nonActiveCrystal;
    public GameObject activeCrystal;
    public float interactionCooldown = 1f;

    private bool isCrystalActive;
    private float lastInteractionTime = -10;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            SwitchCrystal();
        }
    }

    private void SwitchCrystal()
    {
        if (Time.time < lastInteractionTime + interactionCooldown) return;

        isCrystalActive = !isCrystalActive;

        if(isCrystalActive)
        {
            nonActiveCrystal.SetActive(false);
            activeCrystal.SetActive(true);
        }
        else
        {
            nonActiveCrystal.SetActive(true);
            activeCrystal.SetActive(false);
        }

        lastInteractionTime = Time.time;
    }
}