using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactRight : MonoBehaviour
{
    private GetItem_map getmap;
    private playerMove Move;

    private bool activated_1;
    private int IsItem;
    private int Retc;
    private int Rdc;
    public GameObject go_1;
    public GameObject go_2;
    public int idnum;
    public int idnum1;



    public List<Item> characterItems = new List<Item>();        //캐릭터의 아이템 리스트 작성
    public ItemDatabase itemDatabase;       //데이터베이스에서 정보를 꺼내온다.
    public GetSlot getUI;     //인벤토리의 UI 부분의 정보를 가지고온다.
    public Item item;

    // Start is called before the first frame update
    void Start()
    {
        getmap = FindObjectOfType<GetItem_map>();
        Move = FindObjectOfType<playerMove>();
        IsItem = Random.Range(1, 4);
        Retc = Random.Range(0, 8);
        Rdc = Random.Range(1, 3);


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            activated_1 = !activated_1;

            if (activated_1)
            {
                go_1.SetActive(true); //파밍창 활성화
                go_2.SetActive(true); //인벤창 활성화
                Move.Speed = 0;
            }
        }

    }

    public void GiveItem(int id)    //아이템의 ID 정보값를 characterItems에 준다. //강제로 아이템을 인벤토리에 옮기는역할 위에 Start에 GiveItem()을 통하여
    {
        Item itemToAdd = itemDatabase.GetItem(id);  //아이템의 데이터베이스를 얻는다.
        characterItems.Add(itemToAdd);              //characterItem에 해당 아이템을 집어넣는다.
        getUI.AddNewItem(itemToAdd);      //UIinventory기능으로 아이템을 넣는다.
    }

    public Item CheckForItem(int id)        //이 아이템이 여기에 있는게 맞는지 확인한다. ~드래그 시 확인용
    {
        return characterItems.Find(item => item.id == id);
    }

    public void RemoveItem(int id)      //마찬가지로 아이템 제거시
    {
        Item itemToRemove = CheckForItem(id);
        if (itemToRemove != null)
        {
            characterItems.Remove(itemToRemove);
            getUI.RemoveItem(itemToRemove);
            Debug.Log("Removed item: " + itemToRemove.title);
        }
    }
    public void Get_item()
    {
        //영상용 하드코딩
        for (int i = 0; i < 1; i++)
        {
            Rdc = Random.Range(1, 3);
            Retc = Random.Range(0, 8);
            GiveItem(idnum);
            GiveItem(idnum1);
        }
    }
}
