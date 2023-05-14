using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story2 : MonoBehaviour
{
    private playerMove Move;
    GameObject Player;
    GameObject Player_Text;
    GameObject talkstory2;
    public int storycount = 0;

    // Start is called before the first frame update
    void Start()
    {
        Move = FindObjectOfType<playerMove>();
        Player = GameObject.Find("Player_image");
        Player_Text = GameObject.Find("Text_player");
        talkstory2 = GameObject.Find("Talk_story2");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            talkstory2.SetActive(true);
        }
    }

    public void OnClick()
    {
        storycount++;
        Debug.Log("버튼클릭");


        if (storycount == 1)
        {
            Player_Text.GetComponent<Text>().text = " 어? 작동되네? ";
            Move.Speed = 0;
            Debug.Log("대화 변경");
        }

        else if (storycount == 2)
        {
            Player.SetActive(false);
            Player_Text.GetComponent<Text>().text = " 컴퓨터로 갈만한 곳을 찾아보자. ";

            Debug.Log("대화 변경");
        }
        else if (storycount == 3)
        {
            Move.Speed = 30;
            talkstory2.SetActive(false);
        }

    }
}
