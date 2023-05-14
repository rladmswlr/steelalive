using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bed_loading : MonoBehaviour
{
    private GameObject loading1;
    private Animator ani;
    private int count = 0;
    private float health;
    // Start is called before the first frame update
    void Start()
    {
        loading1 = GameObject.Find("bed_loading");
        ani = loading1.GetComponent<Animator>();
        health = GameObject.Find("Player").GetComponent<PlayerStatus>().C_Happy; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onclick()
    {
        ani.SetBool("istrue", true);
        Invoke("Cool", 1.05f);
    }

   

    void Cool()
    {
        ani.SetBool("istrue", false);
        health = health + 50;
    }
}
