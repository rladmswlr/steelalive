using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circle_Timelimit : MonoBehaviour
{

    public Image Elec;
    private bool canSlider;
    private float EnergyTime;

    // Use this for initialization
    void Start()
    {
        canSlider = true;
        EnergyTime = GameObject.Find("Player").GetComponent<PlayerStatus>().C_Elec;
    }

    // Update is called once per frame
    void Update()
    {
        EnergyTime = GameObject.Find("Player").GetComponent<PlayerStatus>().C_Elec;
        if (canSlider)
        {
            Elec.fillAmount = EnergyTime / 100;
            if (EnergyTime == 0)
            {
                Elec.fillAmount = 0.0f;
                canSlider = false;
            }
        }
    }
}
