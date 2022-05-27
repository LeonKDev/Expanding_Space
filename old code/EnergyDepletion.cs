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
    public bool energyDown;


    // Start is called before the first frame update
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
        if (Input.GetMouseButtonDown(1) && energyDown == false)
            energyDown = true;
        else if (Input.GetMouseButtonDown(1) && energyDown == true)
            energyDown = false;

        if (energyDown == true)
        {
            DecreaseEnergy();
        }

        energyBar.value = energy;

    }
    private void DecreaseEnergy()
    {
        if(energy > 0)
            energy -= dValue * Time.deltaTime;
    }

    //private void IncreaseEnergy()
    // {
    //     energy -= dValue * Time.deltaTime;
    // }
    
}
