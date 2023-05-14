using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkImageColor : MonoBehaviour
{

    GameObject Playerimg;
    GameObject Cyborgimg;
    GameObject Talk_text;
    GameObject Cyborg;
    GameObject Talk;

    public float Favorabilityvalue;
    public bool checkbt;
    public int textcount = 0;
    private Animator animator;
    bool CyborgMove;

    // Start is called before the first frame update
    void Start()
    {


        animator = GetComponent<Animator>();

        Cyborg = GameObject.Find("Cyborg");

        Playerimg = GameObject.Find("Playerimg");

        Cyborgimg = GameObject.Find("Cyborgimg");

        Talk_text = GameObject.Find("Talk_text");

        Talk = GameObject.Find("Talk");

        Playerimg.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0.5f);

        //Cyborg.GetComponent<CyborgMove>().enabled = false;

        Favorabilityvalue = Random.Range(0, 20);

        //CyborgMove = false;

        checkbt = true;
        textcount = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClickbt()
    {
        textcount++;
        Favorabilityvalue += 3;
        if (checkbt == true)
        {
            checkbt = false;
            Playerimg.GetComponent<Image>().color = new Color(255, 255, 255, 1f);
            Cyborgimg.GetComponent<Image>().color = new Color(255, 255, 255, 0.5f);
        }
        else if (checkbt == false)
        {
            checkbt = true;
            Cyborgimg.GetComponent<Image>().color = new Color(255, 255, 255, 1f);
            Playerimg.GetComponent<Image>().color    = new Color(255, 255, 255, 0.5f);
        }
        if (textcount == 0)
        {
            Talk_text.GetComponent<Text>().text = "안녕 난 배고파.. 너 때리고싶다";
        }
        else if (textcount == 1)
        {
            Talk_text.GetComponent<Text>().text = "안녕 그래 난 널 때릴거야";
        }
        else if (textcount == 2)
        {
            Talk_text.GetComponent<Text>().text = "그래 한번 때려보시지? ㅋㅋ";

        }

        else if (textcount >= 70)
        {
            Talk_text.GetComponent<Text>().text = "자네.. 블랙마켓이라고 들어봤나?";
        }

        

    }

}

