using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade_Item : MonoBehaviour
{
    private Inventory inventory;
    private UIItem uIItem;
    private UIInventory uIInventory;
    private Crafting_material crafting_material;
    private Animator animator;
    
    public List<UIItem> uiItems = new List<UIItem>();   //UIItem의 정보를 가지고옴
    public List<UIItem> items = new List<UIItem>();
    public Item itemfile;

    public int isivck = 0;
    public int ck;
    private int count= 0;
    public int mtr1_id;
    public int mtr2_id;
    public int mtr1_count;
    public int mtr2_count;

    public GameObject suit1;
    public GameObject suit2;
    public GameObject material1;
    public GameObject material2;
    private GameObject loading;

    public bool isupgrade = false;


    // Start is called before the first frame update
    void Start()
    {
        isivck = 0;
        isupgrade = false;
        inventory = FindObjectOfType<Inventory>();
        uIItem = FindObjectOfType<UIItem>();
        loading = GameObject.Find("loading");
        uIInventory = FindObjectOfType<UIInventory>();
        crafting_material = FindObjectOfType<Crafting_material>();
        animator = loading.GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(count ==1)
        {
            material1.SetActive(true);
            material2.SetActive(false);
            suit1.SetActive(false);
            suit2.SetActive(true);
            for (int i = 0; i < 24; i++)
            {
                inventory.RemoveItem(i);
            }
            Debug.Log("complite");
            count--;
        }
    }

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("istrue", true);
            Invoke("cool", 3.0f);
            Debug.Log("istrue");
            
                   
        }

    }
    void cool()
    {
        animator.SetBool("istrue",false);
        count++;
    }
}
