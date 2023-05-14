using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGManager : MonoBehaviour
{
    GameObject HomeBg;
    GameObject House1Bg;
    GameObject House2Bg;
    GameObject DepBg1;
    GameObject DepBg2;
    GameObject DepBg3;
    GameObject FactBg1;
    GameObject FactBg2;

    int Hour = 10;

    private SpriteRenderer HomeSp;
    private SpriteRenderer House1Sp;
    private SpriteRenderer House2Sp;
    private SpriteRenderer DepSp1;
    private SpriteRenderer DepSp2;
    private SpriteRenderer DepSp3;
    private SpriteRenderer FactSp1;
    private SpriteRenderer FactSp2;

    public Sprite[] BackGround;

    void Start()
    {
        HomeBg = GameObject.Find("HomeBg");
        House1Bg = GameObject.Find("House1Bg");
        House2Bg = GameObject.Find("House2Bg");
        DepBg1 = GameObject.Find("DepBg1");
        DepBg2 = GameObject.Find("DepBg2");
        DepBg3 = GameObject.Find("DepBg3");
        FactBg1 = GameObject.Find("FactBg1");
        FactBg2 = GameObject.Find("FactBg2");

        HomeSp = HomeBg.GetComponent<SpriteRenderer>();
        House1Sp = House1Bg.GetComponent<SpriteRenderer>();
        House2Sp = House2Bg.GetComponent<SpriteRenderer>();
        DepSp1 = DepBg1.GetComponent<SpriteRenderer>();
        DepSp2 = DepBg2.GetComponent<SpriteRenderer>();
        DepSp3 = DepBg3.GetComponent<SpriteRenderer>();
        FactSp1 = FactBg1.GetComponent<SpriteRenderer>();
        FactSp2 = FactBg2.GetComponent<SpriteRenderer>();

        HomeSp.sprite = BackGround[0];
        House1Sp.sprite = BackGround[0];
        House2Sp.sprite = BackGround[0];
        DepSp1.sprite = BackGround[0];
        FactSp1.sprite = BackGround[0];
        FactSp2.sprite = BackGround[0];

        DepSp2.sprite = BackGround[4];
        DepSp3.sprite = BackGround[4];
    }

    
    void Update()
    {
        this.Hour = MinTime.instance.Hour;
        ChangeBg();
    }

    void ChangeBg()
    {
        if(Hour >= 17 && Hour < 21)
        {
            HomeSp.sprite = BackGround[1];
            House1Sp.sprite = BackGround[1];
            House2Sp.sprite = BackGround[1];
            DepSp1.sprite = BackGround[1];
            FactSp1.sprite = BackGround[1];
            FactSp2.sprite = BackGround[1];

            DepSp2.sprite = BackGround[5];
            DepSp3.sprite = BackGround[5];
        }

        if(Hour >= 21 || Hour < 5)
        {
            HomeSp.sprite = BackGround[2];
            House1Sp.sprite = BackGround[2];
            House2Sp.sprite = BackGround[2];
            DepSp1.sprite = BackGround[2];
            FactSp1.sprite = BackGround[2];
            FactSp2.sprite = BackGround[2];

            DepSp2.sprite = BackGround[6];
            DepSp3.sprite = BackGround[6];
        }

        if(Hour >= 5 && Hour < 9)
        {
            HomeSp.sprite = BackGround[3];
            House1Sp.sprite = BackGround[3];
            House2Sp.sprite = BackGround[3];
            DepSp1.sprite = BackGround[3];
            FactSp1.sprite = BackGround[3];
            FactSp2.sprite = BackGround[3];

            DepSp2.sprite = BackGround[7];
            DepSp3.sprite = BackGround[7];
        }

        if(Hour >= 9 && Hour < 17)
        {
            HomeSp.sprite = BackGround[0];
            House1Sp.sprite = BackGround[0];
            House2Sp.sprite = BackGround[0];
            DepSp1.sprite = BackGround[0];
            FactSp1.sprite = BackGround[0];
            FactSp2.sprite = BackGround[0];

            DepSp2.sprite = BackGround[4];
            DepSp3.sprite = BackGround[4];
        }
    }
}
