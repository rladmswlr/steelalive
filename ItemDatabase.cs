using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>(); //아이템의 기본적인 데이터베이스 값 받기

    void Awake()
    {
        BuildDatabase();        //시작할때 BuildDatabase 함수를 호출
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);        //반복을 통하여서 아이템 리스트에서 특정 아이템 ID를 찾아낸다.
    }

    public Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);      //제목을 사용하여서 아이템 인벤토리화면에 액세스 하는역할
    }

    void BuildDatabase()
    {
        items = new List<Item>() {                  //아이템 값을 넣어준다. *이곳이 아이템 데이터베이스의 기본이 되는곳
            new Item(0, "나무", "단단한 나무.",
            new Dictionary<string, int> {
                { "Power", 15 },
                { "Defence", 10 }
            }),
            new Item(1, "유리", "잘 깨지는 유리",
            new Dictionary<string, int> {
                { "Value", 300 }
            }),
            new Item(2, "철", "단단한 철",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(3, "고무", "질긴 고무",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(4, "구리", "무언가를 만드는데 사용할 수 있을것같다.",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(5, "티타늄", "무언가를 만드는데 사용할 수 있을것같다.",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(6, "보리", "무언가를 만드는데 사용할 수 있을것같다.",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(7, "건전지", "전력을 충전할 수 있을것같다.",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(8, "가즈아늄", "고귀한 가즈아늄",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(9, " Boop2", "???:뿝",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(10, "블수원샷", "황소 기운이 쑥쑥 블수원샷!",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(11, "더치페이", "n분의 1",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(12, "빠루", "내구도를 회복할 수 있을것같다.",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(13, "장도리", "내구도를 회복할 수 있을것같다.",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(14, "몽키스패너", "내구도 30을 회복할 수 있을것같다.",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(15, "아싸히", "마시면 어떻게될까?",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(16, "구리전선", "어딘가 강화하는데 사용 할 수 있을것같다.",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(17, "철 전선", "어딘가 강화하는데 사용 할 수 있을것같다.",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(18, "티타늄 전선", "어딘가 강화하는데 사용 할 수 있을것같다.",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(19, "가즈아늄 전선", "어딘가 강화하는데 사용 할 수 있을것같다.",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(20, "전동퀵보드", "빠르게 이동할 수 있을것같다.",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(21, "어디에도문", "한순간에 이동할 수 있을것같다.",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(22, "파파손", "???:내가 여기서 떨어질것같냐?",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(23, "선인장", "마음 평화롭게 해준다.",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(24, "쇼파", "앉으면 일어나지 못할정도의 편안함",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(25, "침대", "별이 다섯개!",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(26, "TV", "고오급 TV",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
            new Item(27, "만화책", "투피스 마지막권",
            new Dictionary<string, int> {
                
            }),
            new Item(28, "피규어", "어디선가 본듯한 피규어",
            new Dictionary<string, int> {
                { "Power", 5 },
                { "Mining", 20}
            }),
        };
    }
}
