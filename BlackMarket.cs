using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackMarket : MonoBehaviour
{
    private Favorability favor;
    public TalkImageColor talk;
    [SerializeField]
    private int Isrand;
    [SerializeField]
    public bool Isblack;
    // Start is called before the first frame update
    void Start()
    {
        favor = FindObjectOfType<Favorability>();
        talk = FindObjectOfType<TalkImageColor>();
        Isrand = Random.Range(0, 4);
        Isblack = false;
    }

    // Update is called once per frame
    void Update()
    {
        createBlack();
    }


    void createBlack()
    {
        if( favor.Favorability_Gage.value > 10 && Isrand >= 0)
        {
            Isblack = true;
            talk.textcount = 70;
        }
    }
}
