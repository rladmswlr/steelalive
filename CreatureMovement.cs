using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CreatureMovement : MonoBehaviour
{
    public float speed;

    private bool movingRight = true;
    private Animator animator;
    public Transform groundDetection;
    public GameObject Enemy;

    bool isTracing;
    bool isMoving;
    GameObject traceTaget;
    GameObject Player;
    GameObject danger;
    GameObject fight;
    GameObject Fight_bt;
    GameObject Defense_bt;
    private int count = 1;
    PlayerStatus PlayerStat;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        danger = GameObject.Find("danger");
        animator = GetComponent<Animator>();
        PlayerStat = FindObjectOfType<PlayerStatus>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        Vector2 Enemy_position = Enemy.transform.position;
        Vector2 Player_position = Player.transform.position;

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f);
        if (groundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }

        float distance = Vector2.Distance(Player.transform.position, Enemy.transform.position);

        if (distance < 60 && isMoving == true)
        {
            speed = 0;


        }
        else if (distance > 61 && isMoving == false)
        {
            speed = 50;
        }

        if (distance < 70 && count == 1)
        {

            if (Enemy_position.x > Player_position.x)   // 적이 플레이어보다 오른쪽에 위치할 때
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
            }
            count = 0;
            animator.SetBool("fight", true);
            PlayerStat.C_Armor -= 10;
            Invoke("coolDown", 1.5f);
        }
        else
            animator.SetBool("fight", false);


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            traceTaget = other.gameObject;

            danger.GetComponent<Renderer>().enabled = true;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTracing = true;
            speed += 1;
            isMoving = true;
            if (speed >= 100)
            {
                speed = 100;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTracing = false;
            isMoving = false;

            speed = 50;

            danger.GetComponent<Renderer>().enabled = false;

        }
    }
    void coolDown()
    {
        count = 1;
    }
}
