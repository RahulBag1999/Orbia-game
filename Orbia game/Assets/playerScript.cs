using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float speed;
    public Transform target;
    private bool move = false;
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            move = true;
        }
        if(move==true)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
        }
        if(transform.position==target.position)
        {
            move = false;
            target = target.GetComponent<ringScript>().targetRing.GetComponent<Transform>();
        }
    }

    
    
}
