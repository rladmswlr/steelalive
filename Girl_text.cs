using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Girl_text : MonoBehaviour
{
    GameObject Player;
    GameObject Girl;
    GameObject Player_Text;
    GameObject Girl_Text;
    GameObject Talk_Girl;


    public int count = 0;

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
        count++;
        Debug.Log("버튼클릭");

        if (count == 1)
        {
            Girl_Text.SetActive(true);
            Player_Text.SetActive(false);
            Girl_Text.GetComponent<Text>().text = " 응. 너는 여기에 무슨 일이야? ";
            Player.SetActive(false);
            Girl.SetActive(true);
            Debug.Log("대화 변경");
        }
        else if (count == 2)
        {
            Girl_Text.SetActive(false);
            Player_Text.SetActive(true);
            Player_Text.GetComponent<Text>().text = " 주변에 돌아다니면서 이것저것 줍는 중이야. ";
            Girl.SetActive(false);
            Player.SetActive(true);
        }
        else if (count == 3)
        {
            Girl_Text.SetActive(true);
            Player_Text.SetActive(false);
            Girl_Text.GetComponent<Text>().text = " 더 필요한건 없어? ";
            Girl.SetActive(true);
            Player.SetActive(false);
        }
        else if (count == 4)
        {
            Girl_Text.SetActive(false);
            Player_Text.SetActive(true);
            Girl.SetActive(false);
            Player.SetActive(true);
            Player_Text.GetComponent<Text>().text = " 왜?";
        }
        else if (count == 5)
        {
            Girl_Text.SetActive(true);
            Player_Text.SetActive(false);
            Girl.SetActive(true);
            Player.SetActive(false);
            Girl_Text.GetComponent<Text>().text = " 아니, 내일모레 암상인이 가정집2에 저녁 10~12시에 온다고 하더라고" + "\n" +"참고로 그 암상인은 철을 좋아하더라고 ? ";
        }

        else if (count == 6)
        {
            Girl_Text.SetActive(true);
            Player_Text.SetActive(false);
            Girl.SetActive(true);
            Player.SetActive(false);
            Girl_Text.GetComponent<Text>().text = "온다고 하더라고 참고로 그 암상인은 철을 좋아하더라고 ? ";
        }

        else if (count == 7)
        {
            Girl_Text.SetActive(false);
            Player_Text.SetActive(true);
            Girl.SetActive(false);
            Player.SetActive(true);
            Player_Text.GetComponent<Text>().text = " 와... 정말 고마워. 다음에 볼 수 있으면 또 보자.";
        }

        else if (count == 8)
        {
            Talk_Girl.SetActive(false);
            Debug.Log("sadsafsagfsgd");
        }

    }

}
