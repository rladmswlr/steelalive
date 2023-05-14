using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circle_Health : MonoBehaviour
{

    public Image Armor;
    private bool canSlider;
    private float Health;


    // Use this for initialization
    void Start()
    {
        canSlider = true;
        Health = GameObject.Find("Player").GetComponent<PlayerStatus>().C_Armor;
    }

    // Update is called once per frame
    void Update()
    {
        Health = GameObject.Find("Player").GetComponent<PlayerStatus>().C_Armor;
        if (canSlider)
        {
            Armor.fillAmount = Health / 100;
            if (Health == 0)
            {
                Armor.fillAmount = 0.0f;
                canSlider = false;
            }
        }
    }
}
