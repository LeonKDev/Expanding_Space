using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyDepletion : MonoBehaviour
{
    public float energy;
    float maxEnergy;

    public Slider energyBar;
    public float dValue;

    // Start is called before the first frame update
    void Start()
    {
        maxEnergy = energy;
        energyBar.maxValue = maxEnergy;
        energyBar.value = energy;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
            DecreaseEnergy();
        else if (energy != maxEnergy)
            IncreaseEnergy();

        energyBar.value = energy;

    }
    private void DecreaseEnergy()
    {
        if(energy != 0)
        energy -= dValue * Time.deltaTime;
    }

    private void IncreaseEnergy()
     {
         energy -= dValue * Time.deltaTime;
     }
    
}
