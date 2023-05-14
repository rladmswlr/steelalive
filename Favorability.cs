using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Favorability : MonoBehaviour
{

    public Slider Favorability_Gage;
    TalkImageColor Favority;

    // Start is called before the first frame update
    void Start()
    {
        Favority = FindObjectOfType<TalkImageColor>();
    }

    // Update is called once per frame
    void Update()
    {
        Favorability_Gage.value = Favority.Favorabilityvalue;
    }

}
