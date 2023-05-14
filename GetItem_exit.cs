using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem_exit : MonoBehaviour
{
    private GetItem_map getmap;
    private playerMove Move;
    private GetItem getitem;
    private UIItem uiitem;
    private GetSlot getSlot;

    private bool activated_1;
    public GameObject go_1;
    public GameObject go_2;
    // Start is called before the first frame update
    void Start()
    {
        getmap = FindObjectOfType<GetItem_map>();
        Move = FindObjectOfType<playerMove>();
        getitem = FindObjectOfType<GetItem>();
        getSlot = FindObjectOfType<GetSlot>();
    }

    // Update is called once per frame
    void Update()
    {   
        
    }

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
                go_1.SetActive(false); //파밍창 비활성화
                go_2.SetActive(false); //인벤창 비활성화
                Move.Speed = 30;
                for (int i = 0; i < 4; i++)
                {
                if (getSlot.uiItems[i].item != null)
                    getSlot.uiItems[i].UpdateItem(null);
                }
        }
    }
}