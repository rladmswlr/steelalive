using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story1_map : MonoBehaviour
{
    
    GameObject talkstory1;

    // Start is called before the first frame update
    void Start()
    {

        talkstory1 = GameObject.Find("Talk_story1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            talkstory1.SetActive(true);
        }
    }
}
