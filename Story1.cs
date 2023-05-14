using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story1 : MonoBehaviour
{
    private playerMove Move;
    GameObject Player;
    GameObject Player_Text;
    GameObject talkstory1;
    public int storycount = 0;

    // Start is called before the first frame update
    void Start()
    {
        Move = FindObjectOfType<playerMove>();
        Player = GameObject.Find("Player_image");
        Player_Text = GameObject.Find("Text_player");
        talkstory1 = GameObject.Find("Talk_story1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            talkstory1.SetActive(true);
        }
    }

    public void OnClick()
    {
        storycount++;
        Debug.Log("버튼클릭");

        if (storycount == 1)
        {
            Move.Speed = 0;
            Player.SetActive(false);
            Player_Text.GetComponent<Text>().text = " 컴퓨터 쪽으로 이동해보자 ";

            Debug.Log("대화 변경");
        }
        else if (storycount == 2)
        {
            Move.Speed = 30;
            talkstory1.SetActive(false);
        }

    }
}
