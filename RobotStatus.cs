using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class RobotStatus : MonoBehaviour
{
    int Min;
    GameObject Cyborg;
    public GameObject Enemy;
    GameObject Player;
    private Animator animator;
    private int health = 100;
    public int c_Attack = 10;
    public int c_Armor = 100;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        //Enemy = GameObject.Find("enemy_robot");
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (c_Armor <= 0)
        {
            Enemy.SetActive(false);
        }
        Damaged();
    }
    void Damaged()
    {
        Vector2 Enemy_position = Enemy.transform.position;
        Vector2 Player_position = Player.transform.position;
        if (health > c_Armor)
        {
            if (Enemy_position.x > Player_position.x)   // 적이 플레이어보다 오른쪽에 위치할 때
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                transform.Translate(new Vector3(2, 0, 0));
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                transform.Translate(new Vector3(2, 0, 0));
            }
            animator.SetBool("isDamage", true);
            Debug.Log("피격된 로봇");
            Invoke("cool", 0.3f);
        }
        else
            animator.SetBool("isDamage", false);
    }
    void cool()
    {
        health = c_Armor;
    }
}