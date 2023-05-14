using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Girl_Comunicate : MonoBehaviour
{
    GameObject Player;
    GameObject Girl;
    GameObject Player_Text;
    GameObject Girl_Text;
    GameObject Talk_Girl;

    public bool activated_1;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player_image");
        Girl = GameObject.Find("Girl_image");
        Player_Text = GameObject.Find("Text_player");
        Girl_Text = GameObject.Find("Text_girl");
        Girl.SetActive(false);
        Girl_Text.SetActive(false);
        Talk_Girl = GameObject.Find("TalkGirl1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Debug.Log("은직은직");
    }
}
