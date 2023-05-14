using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{ 
    GameObject Homebtn;
    GameObject House1btn;
    GameObject House2btn;
    GameObject Depbtn;
    GameObject Factbtn;

    GameObject Home_ex;
    GameObject House1_ex;
    GameObject House2_ex;
    GameObject Dep_ex;
    GameObject Fact_ex;

    private void Awake()
    {
        Homebtn = GameObject.Find("Homebtn");
        House1btn = GameObject.Find("House1btn");
        House2btn = GameObject.Find("House2btn");
        Depbtn = GameObject.Find("Depbtn");
        Factbtn = GameObject.Find("Factbtn");

        Home_ex = GameObject.Find("Home_ex");
        House1_ex = GameObject.Find("House1_ex");
        House2_ex = GameObject.Find("House2_ex");
        Dep_ex = GameObject.Find("Dep_ex");
        Fact_ex = GameObject.Find("Fact_ex");
    }

    void Start()
    {
        Home_ex.SetActive(false);
        House1_ex.SetActive(false);
        House2_ex.SetActive(false);
        Dep_ex.SetActive(false);
        Fact_ex.SetActive(false);
    }

    public void Home_exOn()
    {
        Home_ex.SetActive(true);
        House1btn.GetComponent<Button>().enabled = false;
        House2btn.GetComponent<Button>().enabled = false;
        Depbtn.GetComponent<Button>().enabled = false;
        Factbtn.GetComponent<Button>().enabled = false;
    }

    public void House1_exOn()
    {
        House1_ex.SetActive(true);
        Homebtn.GetComponent<Button>().enabled = false;
        House2btn.GetComponent<Button>().enabled = false;
        Depbtn.GetComponent<Button>().enabled = false;
        Factbtn.GetComponent<Button>().enabled = false;
    }

    public void House2_exOn()
    {
        House2_ex.SetActive(true);
        Homebtn.GetComponent<Button>().enabled = false;
        House1btn.GetComponent<Button>().enabled = false;
        Depbtn.GetComponent<Button>().enabled = false;
        Factbtn.GetComponent<Button>().enabled = false;
    }

    public void Dep_exOn()
    {
        Dep_ex.SetActive(true);
        House1btn.GetComponent<Button>().enabled = false;
        House2btn.GetComponent<Button>().enabled = false;
        Homebtn.GetComponent<Button>().enabled = false;
        Factbtn.GetComponent<Button>().enabled = false;
    }

    public void Fact_exOn()
    {
        Fact_ex.SetActive(true);
        House1btn.GetComponent<Button>().enabled = false;
        House2btn.GetComponent<Button>().enabled = false;
        Depbtn.GetComponent<Button>().enabled = false;
        Homebtn.GetComponent<Button>().enabled = false;
    }

    public void Home_exOff()
    {
        Home_ex.SetActive(false);
        House1btn.GetComponent<Button>().enabled = true;
        House2btn.GetComponent<Button>().enabled = true;
        Depbtn.GetComponent<Button>().enabled = true;
        Factbtn.GetComponent<Button>().enabled = true;
    }

    public void House1_exOff()
    {
        House1_ex.SetActive(false);
        Homebtn.GetComponent<Button>().enabled = true;
        House2btn.GetComponent<Button>().enabled = true;
        Depbtn.GetComponent<Button>().enabled = true;
        Factbtn.GetComponent<Button>().enabled = true;
    }

    public void House2_exOff()
    {
        House2_ex.SetActive(false);
        House1btn.GetComponent<Button>().enabled = true;
        Homebtn.GetComponent<Button>().enabled = true;
        Depbtn.GetComponent<Button>().enabled = true;
        Factbtn.GetComponent<Button>().enabled = true;
    }

    public void Dep_exOff()
    {
        Dep_ex.SetActive(false);
        House1btn.GetComponent<Button>().enabled = true;
        House2btn.GetComponent<Button>().enabled = true;
        Homebtn.GetComponent<Button>().enabled = true;
        Factbtn.GetComponent<Button>().enabled = true;
    }

    public void Fact_exOff()
    {
        Fact_ex.SetActive(false);
        House1btn.GetComponent<Button>().enabled = true;
        House2btn.GetComponent<Button>().enabled = true;
        Depbtn.GetComponent<Button>().enabled = true;
        Homebtn.GetComponent<Button>().enabled = true;
    }

    public void Btn_On()
    {
        Homebtn.GetComponent<Button>().enabled = true;
        House1btn.GetComponent<Button>().enabled = true;
        House2btn.GetComponent<Button>().enabled = true;
        Depbtn.GetComponent<Button>().enabled = true;
        Factbtn.GetComponent<Button>().enabled = true;
    }
}
