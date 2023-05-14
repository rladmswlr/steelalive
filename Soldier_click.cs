using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soldier_click : MonoBehaviour
{
    GameObject Player;
    GameObject Solider;
    GameObject Player_Text;
    GameObject Solider_Text;
    GameObject Talk_Solider;

    public bool activated_1;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player_image");
        Solider = GameObject.Find("Soldier_image");
        Player_Text = GameObject.Find("Text_player");
        Solider_Text = GameObject.Find("Text_soldier");
        Solider.SetActive(false);
        Solider_Text.SetActive(false);
        Talk_Solider = GameObject.Find("Talk_soldier");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        Talk_Solider.SetActive(true);
        Debug.Log("은직은직");
    }
}
