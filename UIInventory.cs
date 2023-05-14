using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//인벤토리의 UI와 관련된 부분 (Sprite나 이미지 등을 사용)
public class UIInventory : MonoBehaviour
{
    private Image material_image1;
    private Crafting_item crafting_Item;
    public List<UIItem> uiItems = new List<UIItem>();   //UIItem의 정보를 가지고옴
    public GameObject slotPrefab;   //슬롯을 만들기위한 준비재료
    public Transform slotPanel; //슬롯의 panel
    Color color;
    public List<UIItem> items = new List<UIItem>();
    bool ischeck = true;

    void Awake()            //슬롯을 생성하고 슬롯안의 아이템 정보를 넣는다.
    {

        crafting_Item = GetComponent<Crafting_item>();

        for (int i = 0; i < 24; i++)
        {
            GameObject instance = Instantiate(slotPrefab) as GameObject;
            instance.transform.SetParent(slotPanel);
            uiItems.Add(instance.GetComponentInChildren<UIItem>());

            items[i] = uiItems[i];
        }


    }

    public void checkinven()
    {
        for (int i = 0; i < 24; i++)
        {
            if (items[i].item != null)
            {
                Debug.Log(i + " " + items[i].item.id + " " + items[i].item.itemcount);
            }
        }
    }

    public void itemcombine(int a, int b)
    {
        for (int i = 0; i < 24; i++)
        {
            for (int j = 0; j < 24; j++)
            {

                if (items[i].item != null && items[i].item.id == b && i != j)
                {
                    Item cloneIt = new Item(uiItems[i].item);
                    cloneIt.itemcount = items[i].item.itemcount + a;
                    Debug.Log("ds");

                    uiItems[i].UpdateItem(null);
                    uiItems[i].UpdateItem(cloneIt);

                    UpdateSlot((items[i].item == cloneIt), cloneIt);
                    break;
                }

            }
        }
    }

    public int CheckItem(int iv, int id1, int id2, int id3, int ct1, int ct2, int ct3)
    {
        for (int i = 0; i < 24; i++)
        {
            if (uiItems[i].item != null && uiItems[i].item.id == id1 && uiItems[i].item.itemcount >= ct1)
            {
                GameObject.Find("material1_image").GetComponent<Image>().color = new Color(255, 255, 255, 255);
                break;
            }

            else
            {
                GameObject.Find("material1_image").GetComponent<Image>().color = new Color(255, 255, 255, 0.3f);
            }
        }

        for (int i = 0; i < 24; i++)
        {
            if (uiItems[i].item != null && uiItems[i].item.id == id2 && uiItems[i].item.itemcount >= ct2)
            {
                GameObject.Find("material2_image").GetComponent<Image>().color = new Color(255, 255, 255, 255);
                break;
            }

            else
            {
                GameObject.Find("material2_image").GetComponent<Image>().color = new Color(255, 255, 255, 0.3f);
            }
        }

        for (int i = 0; i < 24; i++)
        {
            if (uiItems[i].item != null && uiItems[i].item.id == id3 && uiItems[i].item.itemcount >= ct3)
            {
                GameObject.Find("material3_image").GetComponent<Image>().color = new Color(255, 255, 255, 255);
                break;
            }

            else
            {
                GameObject.Find("material3_image").GetComponent<Image>().color = new Color(255, 255, 255, 0.3f);
            }
        }

        if (iv == 3)
        {
            for (int i = 0; i < 24; i++)
            {
                if (uiItems[i].item != null && uiItems[i].item.id == id1 && uiItems[i].item.itemcount >= ct1)
                {

                    if (uiItems[i].item.itemcount >= 2)
                    {
                        uiItems[i].item.itemcount -= 1;
                    }

                    else if (uiItems[i].item.itemcount == 1)
                    {
                        uiItems[i].UpdateItem(null);
                    }
                    break;
                }
            }

            for (int i = 0; i < 24; i++)
            {
                if (uiItems[i].item != null && uiItems[i].item.id == id2 && uiItems[i].item.itemcount >= ct2)
                {

                    if (uiItems[i].item.itemcount >= 2)
                    {
                        uiItems[i].item.itemcount -= 1;
                    }

                    else if (uiItems[i].item.itemcount == 1)
                    {
                        uiItems[i].UpdateItem(null);
                    }
                    break;
                }
            }

            for (int i = 0; i < 24; i++)
            {
                if (uiItems[i].item != null && uiItems[i].item.id == id3 && uiItems[i].item.itemcount >= ct3)
                {

                    if (uiItems[i].item.itemcount >= 2)
                    {
                        uiItems[i].item.itemcount -= 1;
                    }

                    else if (uiItems[i].item.itemcount == 1)
                    {
                        uiItems[i].UpdateItem(null);
                    }
                    break;
                }
            }
        }



        return iv;
    }

    public int Checkinventory(int iv, int id1, int id2, int id3, int ct1, int ct2, int ct3)
    {
        for (int i = 0; i < 24; i++)
        {
            if (uiItems[i].item != null && uiItems[i].item.id == id1 && uiItems[i].item.itemcount >= ct1)
            {
                iv++;
                break;
            }
        }

        for (int i = 0; i < 24; i++)
        {
            if (uiItems[i].item != null && uiItems[i].item.id == id2 && uiItems[i].item.itemcount >= ct2)
            {
                iv++;
                break;
            }
        }

        for (int i = 0; i < 24; i++)
        {
            if (uiItems[i].item != null && uiItems[i].item.id == id3 && uiItems[i].item.itemcount >= ct3)
            {
                iv++;
                break;
            }
        }

        if (iv == 3)
        {
            for (int i = 0; i < 24; i++)
            {
                if (uiItems[i].item != null && uiItems[i].item.id == id1 && uiItems[i].item.itemcount >= ct1)
                {

                    if (uiItems[i].item.itemcount >= 2)
                    {
                        uiItems[i].item.itemcount -= 1;
                    }

                    else if (uiItems[i].item.itemcount == 1)
                    {
                        uiItems[i].UpdateItem(null);
                    }
                    break;
                }
            }

            for (int i = 0; i < 24; i++)
            {
                if (uiItems[i].item != null && uiItems[i].item.id == id2 && uiItems[i].item.itemcount >= ct2)
                {

                    if (uiItems[i].item.itemcount >= 2)
                    {
                        uiItems[i].item.itemcount -= 1;
                    }

                    else if (uiItems[i].item.itemcount == 1)
                    {
                        uiItems[i].UpdateItem(null);
                    }
                    break;
                }
            }

            for (int i = 0; i < 24; i++)
            {
                if (uiItems[i].item != null && uiItems[i].item.id == id3 && uiItems[i].item.itemcount >= ct3)
                {

                    if (uiItems[i].item.itemcount >= 2)
                    {
                        uiItems[i].item.itemcount -= 1;
                    }

                    else if (uiItems[i].item.itemcount == 1)
                    {
                        uiItems[i].UpdateItem(null);
                    }
                    break;
                }
            }
        }



        return iv;
    }

    public int Checkinventory(int iv, int id1, int id2, int id3, int id4, int ct1, int ct2, int ct3, int ct4)
    {
        for (int i = 0; i < 24; i++)
        {
            if (uiItems[i].item != null && uiItems[i].item.id == id1 && uiItems[i].item.itemcount >= ct1)
            {
                iv++;
                break;
            }
        }

        for (int i = 0; i < 24; i++)
        {
            if (uiItems[i].item != null && uiItems[i].item.id == id2 && uiItems[i].item.itemcount >= ct2)
            {
                iv++;
                break;
            }
        }

        for (int i = 0; i < 24; i++)
        {
            if (uiItems[i].item != null && uiItems[i].item.id == id3 && uiItems[i].item.itemcount >= ct3)
            {
                iv++;
                break;
            }
        }

        for (int i = 0; i < 24; i++)
        {
            if (uiItems[i].item != null && uiItems[i].item.id == id4 && uiItems[i].item.itemcount >= ct4)
            {
                iv++;
                break;
            }
        }

        if (iv == 4)
        {
            for (int i = 0; i < 24; i++)
            {
                if (uiItems[i].item != null && uiItems[i].item.id == id1 && uiItems[i].item.itemcount >= ct1)
                {

                    if (uiItems[i].item.itemcount >= 2)
                    {
                        uiItems[i].item.itemcount -= 1;
                    }

                    else if (uiItems[i].item.itemcount == 1)
                    {
                        uiItems[i].UpdateItem(null);
                    }
                    break;
                }
            }

            for (int i = 0; i < 24; i++)
            {
                if (uiItems[i].item != null && uiItems[i].item.id == id2 && uiItems[i].item.itemcount >= ct2)
                {

                    if (uiItems[i].item.itemcount >= 2)
                    {
                        uiItems[i].item.itemcount -= 1;
                    }

                    else if (uiItems[i].item.itemcount == 1)
                    {
                        uiItems[i].UpdateItem(null);
                    }
                    break;
                }
            }

            for (int i = 0; i < 24; i++)
            {
                if (uiItems[i].item != null && uiItems[i].item.id == id3 && uiItems[i].item.itemcount >= ct3)
                {

                    if (uiItems[i].item.itemcount >= 2)
                    {
                        uiItems[i].item.itemcount -= 1;
                    }

                    else if (uiItems[i].item.itemcount == 1)
                    {
                        uiItems[i].UpdateItem(null);
                    }
                    break;
                }
            }

            for (int i = 0; i < 24; i++)
            {
                if (uiItems[i].item != null && uiItems[i].item.id == id4 && uiItems[i].item.itemcount >= ct4)
                {

                    if (uiItems[i].item.itemcount >= 2)
                    {
                        uiItems[i].item.itemcount -= 1;
                    }

                    else if (uiItems[i].item.itemcount == 1)
                    {
                        uiItems[i].UpdateItem(null);
                    }
                    break;
                }
            }
        }



        return iv;
    }

    private void UpdateSlot(bool v, Item item)
    {
        throw new NotImplementedException();
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