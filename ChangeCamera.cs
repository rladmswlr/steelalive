using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    GameObject HomeCamera;   //우리 커여운 카메라들
    GameObject House1Camera;
    GameObject House2Camera;
    GameObject MapCamera;
    GameObject DepCamera;
    GameObject FactCamera;

    GameObject Player;   //플레이어

    GameObject HomeOb;      //부모들
    GameObject House1Ob;
    GameObject House2Ob;
    GameObject MapOb;
    GameObject DepOb;
    GameObject FactOb;

    GameObject Homebtn;
    GameObject House1btn;
    GameObject House2btn;
    GameObject Depbtn;
    GameObject Factbtn;

    GameObject HomeEf;
    GameObject House1Ef;
    GameObject House2Ef;
    GameObject DepEf;
    GameObject FactEf;

    bool Home = true;
    bool House1 = false;
    bool House2 = false;
    bool Dep = false;
    bool Fact = false;

    private void Awake()
    {
        Homebtn = GameObject.Find("Homebtn");
        House1btn = GameObject.Find("House1btn");
        House2btn = GameObject.Find("House2btn");
        Depbtn = GameObject.Find("Depbtn");
        Factbtn = GameObject.Find("Factbtn");
    }

    void Start()  //카메라 디폴트를 아지트로 설정
    {
        this.Player = GameObject.FindGameObjectWithTag("Player");

        HomeOb = GameObject.Find("HomeParents");
        House1Ob = GameObject.Find("House1Parents");
        House2Ob = GameObject.Find("House2Parents");
        MapOb = GameObject.Find("Map");
        DepOb = GameObject.Find("DepParents");
        FactOb = GameObject.Find("FactParents");
        
        Homebtn = GameObject.Find("Homebtn");
        House1btn = GameObject.Find("House1btn");
        House2btn = GameObject.Find("House2btn");
        Depbtn = GameObject.Find("Depbtn");
        Factbtn = GameObject.Find("Factbtn");

        HomeEf = GameObject.Find("HomeEf");
        House1Ef = GameObject.Find("House1Ef");
        House2Ef = GameObject.Find("House2Ef");
        DepEf = GameObject.Find("DepEf");
        FactEf = GameObject.Find("FactEf");

        HomeCamera = GameObject.Find("HomeCamera");
        House1Camera = GameObject.Find("House1Camera");
        House2Camera = GameObject.Find("House2Camera");
        MapCamera = GameObject.Find("MapCamera");
        DepCamera = GameObject.Find("DepCamera");
        FactCamera = GameObject.Find("FactCamera");

        HomeOb.SetActive(true);
        House1Ob.SetActive(false);
        House2Ob.SetActive(false);
        MapOb.SetActive(false);
        DepOb.SetActive(false);
        FactOb.SetActive(false);

        Homebtn.SetActive(false);
        House1btn.SetActive(false);
        House2btn.SetActive(false);
        Depbtn.SetActive(false);
        Factbtn.SetActive(false);

        HomeEf.SetActive(false);
        House1Ef.SetActive(false);
        House2Ef.SetActive(false);
        DepEf.SetActive(false);
        FactEf.SetActive(false);

        HomeCamera.SetActive(true);
        House1Camera.SetActive(false);
        House2Camera.SetActive(false);
        MapCamera.SetActive(false);
        DepCamera.SetActive(false);
        FactCamera.SetActive(false);
    }

    void Update()
    {
        TPHome();
        TPHouse1();
        TPHouse2();
        TPDep();
    }

    public void GoHome()    //아지트로 돌아갈 때 카메라
    {
        HomeOb.SetActive(true);
        House1Ob.SetActive(false);
        House2Ob.SetActive(false);
        MapOb.SetActive(false);
        DepOb.SetActive(false);
        FactOb.SetActive(false);

        HomeCamera.SetActive(true);
        House1Camera.SetActive(false);
        House2Camera.SetActive(false);
        MapCamera.SetActive(false);
        DepCamera.SetActive(false);
        FactCamera.SetActive(false);

        Homebtn.SetActive(false);
        House1btn.SetActive(false);
        House2btn.SetActive(false);
        Depbtn.SetActive(false);
        Factbtn.SetActive(false);

        Home = true;
        House1 = false;
        House2 = false;
        Dep = false;
        Fact = false;

        Player.transform.position = new Vector3(-430f, -104.8f, 0);
    }

    public void GoHouse1()  //가정집 1로 갈 때 카메라
    {
        HomeOb.SetActive(false);
        House1Ob.SetActive(true);
        House2Ob.SetActive(false);
        MapOb.SetActive(false);
        DepOb.SetActive(false);
        FactOb.SetActive(false);

        HomeCamera.SetActive(false);
        House1Camera.SetActive(true);
        House2Camera.SetActive(false);
        MapCamera.SetActive(false);
        DepCamera.SetActive(false);
        FactCamera.SetActive(false);

        Homebtn.SetActive(false);
        House1btn.SetActive(false);
        House2btn.SetActive(false);
        Depbtn.SetActive(false);
        Factbtn.SetActive(false);

        Home = false;
        House1 = true;
        House2 = false;
        Dep = false;
        Fact = false;

        Player.transform.position = new Vector3(-378.5f, -1916.3f, 0);
    }

    public void GoHouse2()   //가정집 2로 갈 때 카메라
    {
        HomeOb.SetActive(false);
        House1Ob.SetActive(false);
        House2Ob.SetActive(true);
        MapOb.SetActive(false);
        DepOb.SetActive(false);
        FactOb.SetActive(false);

        HomeCamera.SetActive(false);
        House1Camera.SetActive(false);
        House2Camera.SetActive(true);
        MapCamera.SetActive(false);
        DepCamera.SetActive(false);
        FactCamera.SetActive(false);

        Homebtn.SetActive(false);
        House1btn.SetActive(false);
        House2btn.SetActive(false);
        Depbtn.SetActive(false);
        Factbtn.SetActive(false);

        Home = false;
        House1 = false;
        House2 = true;
        Dep = false;
        Fact = false;

        Player.transform.position = new Vector3(-348.0f, -3733.0f, 0);
    }

    public void GoMap()    //지도를 볼 때 카메라
    {
        HomeOb.SetActive(false);
        House1Ob.SetActive(false);
        House2Ob.SetActive(false);
        MapOb.SetActive(true);
        DepOb.SetActive(false);
        FactOb.SetActive(false);

        HomeCamera.SetActive(false);
        House1Camera.SetActive(false);
        House2Camera.SetActive(false);
        MapCamera.SetActive(true);
        DepCamera.SetActive(false);
        FactCamera.SetActive(false);

        Homebtn.SetActive(true);
        House1btn.SetActive(true);
        House2btn.SetActive(true);
        Depbtn.SetActive(true);
        Factbtn.SetActive(true);

        HomeEf.SetActive(true);
        House1Ef.SetActive(true);
        House2Ef.SetActive(true);
        DepEf.SetActive(true);
        FactEf.SetActive(true);
    }

    public void GoDep()
    {
        HomeOb.SetActive(false);
        House1Ob.SetActive(false);
        House2Ob.SetActive(false);
        MapOb.SetActive(false);
        DepOb.SetActive(true);
        FactOb.SetActive(false);

        HomeCamera.SetActive(false);
        House1Camera.SetActive(false);
        House2Camera.SetActive(false);
        MapCamera.SetActive(false);
        DepCamera.SetActive(true);
        FactCamera.SetActive(false);

        Homebtn.SetActive(false);
        House1btn.SetActive(false);
        House2btn.SetActive(false);
        Depbtn.SetActive(false);
        Factbtn.SetActive(false);

        Home = false;
        House1 = false;
        House2 = false;
        Dep = true;
        Fact = false;

        Player.transform.position = new Vector3(3392f, -5567f, 0);
    }

    public void GoFact()
    {
        HomeOb.SetActive(false);
        House1Ob.SetActive(false);
        House2Ob.SetActive(false);
        MapOb.SetActive(false);
        DepOb.SetActive(false);
        FactOb.SetActive(true);

        HomeCamera.SetActive(false);
        House1Camera.SetActive(false);
        House2Camera.SetActive(false);
        MapCamera.SetActive(false);
        DepCamera.SetActive(false);
        FactCamera.SetActive(true);

        Homebtn.SetActive(false);
        House1btn.SetActive(false);
        House2btn.SetActive(false);
        Depbtn.SetActive(false);
        Factbtn.SetActive(false);

        Home = false;
        House1 = false;
        House2 = false;
        Dep = false;
        Fact = true;

        Player.transform.position = new Vector3(-3518.4f, -5560.3f, 0);
    }

    void TPHome()
    {
        Vector3 pPos = this.transform.position;

        if (Home == true)
        {
            Player.GetComponent<HomePMove>().enabled = true;
            Player.GetComponent<House1Move>().enabled = false;
            Player.GetComponent<House2Move>().enabled = false;
            Player.GetComponent<DepMove>().enabled = false;
            //Player.GetComponent<FactMove>().enabled = false;
        }
    }

    void TPHouse1()
    {
        Vector3 pPos = this.transform.position;

        if (House1 == true)
        {
            Player.GetComponent<HomePMove>().enabled = false;
            Player.GetComponent<House1Move>().enabled = true;
            Player.GetComponent<House2Move>().enabled = false;
            Player.GetComponent<DepMove>().enabled = false;
            //Player.GetComponent<FactMove>().enabled = false;
        } 
    }

    void TPHouse2()
    {
        Vector3 pPos = this.transform.position;

        if(House2 == true)
        {
            Player.GetComponent<HomePMove>().enabled = false;
            Player.GetComponent<House1Move>().enabled = false;
            Player.GetComponent<House2Move>().enabled = true;
            Player.GetComponent<DepMove>().enabled = false;
            //Player.GetComponent<FactMove>().enabled = false;
        }
    }
    
    void TPDep()
    {
        Vector3 pPos = this.transform.position;

        if(Dep == true)
        {
            Player.GetComponent<HomePMove>().enabled = false;
            Player.GetComponent<House1Move>().enabled = false;
            Player.GetComponent<House2Move>().enabled = false;
            Player.GetComponent<DepMove>().enabled = true;
            //Player.GetComponent<FactMove>().enabled = false;
        }

    }

    /*void TPFact()
    {
        Vector3 pPos = this.transform.position;

        if(Fact == true)
        {
            Player.GetComponent<HomePMove>().enabled = false;
            Player.GetComponent<House1Move>().enabled = false;
            Player.GetComponent<House2Move>().enabled = false;
            Player.GetComponent<DepMove>().enabled = false;
          //  Player.GetComponent<FactMove>().enabled = true;
        }
    }*/
}
