using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soldier_talk : MonoBehaviour
{
    private playerMove Move;
    GameObject Player;
    GameObject Solider;
    GameObject Player_Text;
    GameObject Solider_Text;
    GameObject Talk_Solider;
    private Inventory inventory;
    public int count = 0 ;

    // Start is called before the first frame update
    void Start()
    {
        Move = FindObjectOfType<playerMove>();
        Player = GameObject.Find("Player_image");
        Solider = GameObject.Find("Soldier_image");
        Player_Text = GameObject.Find("Text_player");
        Solider_Text = GameObject.Find("Text_soldier");
        Solider.SetActive(false);
        Solider_Text.SetActive(false);
        Talk_Solider = GameObject.Find("Talk_Soldier");
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
            Move.Speed = 0;
            Solider_Text.SetActive(true);
            Player_Text.SetActive(false);
            Solider_Text.GetComponent<Text>().text = "응.. 그래서 말인데 구리전선 남은거 있니? ";
            Player.SetActive(false);
            Solider.SetActive(true);
            Debug.Log("대화 변경");
        }
        else if (count == 2)
        {
            Solider_Text.SetActive(false);
            Player_Text.SetActive(true);
            Player_Text.GetComponent<Text>().text = " 응. 여기. ";
            Solider.SetActive(false);
            Player.SetActive(true);
        }
        else if (count == 3)
        {
            Solider_Text.SetActive(true);
            Player_Text.SetActive(false);
            Solider_Text.GetComponent<Text>().text = " 으... 좀 괜찮아졌다. 사례로 철 좀 줄게. ";
            Solider.SetActive(true);
            Player.SetActive(false);
        }
        else if (count == 4)
        {
            Solider_Text.SetActive(false);
            Player_Text.SetActive(true);
            Solider.SetActive(false);
            Player.SetActive(false);
            inventory.GiveItem(2);
            Player_Text.GetComponent<Text>().text = " 철을 얻었다. 아지트로 돌아가도록 하자 ";
        }

        else if (count == 5)
        {
            Talk_Solider.SetActive(false);
            Move.Speed = 30;
            Debug.Log("sadsafsagfsgd");
        }

    }
}
