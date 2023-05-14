using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[SerializeField]
public class Comunicate : MonoBehaviour
{
    GameObject Player;
    GameObject Girl;
    GameObject Player_Text;
    GameObject Girl_Text;
    GameObject Talk_big;

    private Inventory inventory;
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
        Talk_big = GameObject.Find("Talk_big");
        inventory = FindObjectOfType<Inventory>();
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
            Girl_Text.GetComponent<Text>().text = " 엥 내 옆에 있는 로봇은 내 친구야 히히 ";   
            Player.SetActive(false);
            Girl.SetActive(true);  
            Debug.Log("대화 변경");
        }
        else if (count == 2)
        {
            Girl_Text.SetActive(false);
            Player_Text.SetActive(true);
            Player_Text.GetComponent<Text>().text = " 그 친구는 감염되지 않은거야? ";
            Girl.SetActive(false);
            Player.SetActive(true);
        }
        else if (count == 3)
        {
            Girl_Text.SetActive(true);
            Player_Text.SetActive(false);
            Girl_Text.GetComponent<Text>().text = " 응 봐봐 멀쩡한걸? ";
            Girl.SetActive(true);
            Player.SetActive(false);
        }
        else if (count == 4)
        {
            Girl_Text.GetComponent<Text>().text = " 이렇게 오랜만에 살아있는 사람을 보는것도 오랜만이다~ ";
        }
        else if (count == 5)
        {
            Girl_Text.GetComponent<Text>().text = " 혼자 살아가기 힘들지 않아? ";
        }
        else if (count == 6)
        {
            Girl_Text.SetActive(false);
            Player_Text.SetActive(true);
            Player_Text.GetComponent<Text>().text = " 쉽지는 않지. 위험할 때도 있고... ";
            Girl.SetActive(false);
            Player.SetActive(true);
        }
        else if (count == 7)
        {
            Girl_Text.SetActive(true);
            Player_Text.SetActive(false);
            Girl_Text.GetComponent<Text>().text = " 흠... 그렇다면 내가 블수원샷 줄테니깐 위험할 때 써봐 ";
            Girl.SetActive(true);
            Player.SetActive(false);
        }
        else if (count == 8)
        {
            Girl_Text.GetComponent<Text>().text = " 다음에도 볼 쑤 있었으면 좋겠다 히히 ";
        }
        else if (count == 9)
        {
            Girl_Text.GetComponent<Text>().text = " 블수원샷을 획득하였다 ";
            Girl.SetActive(false);
        }
        else if (count == 10)
        {
            Talk_big.SetActive(false);
            inventory.GiveItem(10);
            Debug.Log("sadsafsagfsgd");
        }

    }
}
