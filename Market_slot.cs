using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market_slot : MonoBehaviour
{
    public List<UIItem> uiItems = new List<UIItem>();   //UIItem의 정보를 가지고옴
    public GameObject slotPrefab;   //슬롯을 만들기위한 준비재료
    public Transform slotPanel; //슬롯의 panel

    public List<UIItem> items = new List<UIItem>();

    private Inventory inventory;

    void Awake()            //슬롯을 생성하고 슬롯안의 아이템 정보를 넣는다.
    {
        inventory = FindObjectOfType<Inventory>();
        for (int i = 0; i < 4; i++)
        {
            GameObject instance = Instantiate(slotPrefab);
            instance.transform.SetParent(slotPanel);
            uiItems.Add(instance.GetComponentInChildren<UIItem>());
        }
    }
    private void Update()
    {
        sad();
    }
    public void sad()
    {
        for(int i=0; i<4; i++)
        {
            if(uiItems[i].item != null)
            {
                Debug.Log("ㅁㄴㅇㅁㄴㄹㄴㅁㅀㄴㅁㄹ");
                uiItems[i].UpdateItem(null);
                inventory.GiveItem(14);
            }
        }
        
    }

    public void UpdateSlot(int slot, Item item)     //아이템을 표시하거나 숨길수있도록 함
    {
        uiItems[slot].UpdateItem(item);
    }

    public void AddNewItem(Item item)       //항목이 없는 슬롯에 아이템 첫번째부터 아이템을 집어넣음
    {
        UpdateSlot(uiItems.FindIndex(i => i.item == null), item);
    }

    public void RemoveItem(Item item)   //항목을 제거하고 싶을 경우
    {
        UpdateSlot(uiItems.FindIndex(i => i.item == item), null);
    }
}
