using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class crystal : MonoBehaviour
{
    public GameObject nonActiveCrystal;
    public GameObject activeCrystal;
    public float interactionCooldown = 1f;

    private bool isCrystalActive;
    private float lastInteractionTime = -10;
    private bool haveEnergy;

    public float energy;
    float maxEnergy;

    public Slider energyBar;
    public float dValue;
    public bool energyDown;

    void Start()
    {
        energyDown = false;
        maxEnergy = energy;
        energyBar.maxValue = maxEnergy;
        energyBar.value = energy;
    }

    // Update is called once per frame
    void Update()
    {
        energyBar.value = energy;

        if (isCrystalActive)
        {
            DecreaseEnergy();
        }

        if (Input.GetMouseButtonDown(1) && haveEnergy == true)
        {
            SwitchCrystal();
        }

        if (energy > 0.1)
        {
            haveEnergy = true;
        }

        if (energy < 0.1 && haveEnergy == true)
        {
            haveEnergy = false;
            SwitchCrystal();
        }   
    }
    private void DecreaseEnergy()
    {
        if (energy > 0.01)
            energy -= dValue * Time.deltaTime;
    }

    private void SwitchCrystal()
    {
        if (Time.time < lastInteractionTime + interactionCooldown) return;

        isCrystalActive = !isCrystalActive;

        if (isCrystalActive)
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
