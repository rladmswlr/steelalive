using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circle_Happy : MonoBehaviour
{

    public Image Happy;
    private bool canSlider;
    private float HappyTime;

    // Use this for initialization
    void Start()
    {
        canSlider = true;
        HappyTime = GameObject.Find("Player").GetComponent<PlayerStatus>().C_Happy;
    }

    // Update is called once per frame
    void Update()
    {
        HappyTime = GameObject.Find("Player").GetComponent<PlayerStatus>().C_Happy;
        if (canSlider)
        {
            Happy.fillAmount = HappyTime / 100;
            if (HappyTime == 0)
            {
                Happy.fillAmount = 0.0f;
                canSlider = false;
            }
        }
    }
}