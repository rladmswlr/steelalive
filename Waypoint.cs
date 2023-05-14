using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    GameObject waypoint1;
    // Start is called before the first frame update
    void Start()
    {
        waypoint1 = GameObject.Find("waypoint1");
    }

    private void Update()
    {
        //Vector3 pPos = this.transform.position;

        //waypoint1.transform.position = new Vector3(pPos.x, 2, pPos.z);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(transform.position, 10f);
    }
}

