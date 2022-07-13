using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camScript : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float followSpeed;
    [SerializeField] private float Yoffset;

    
    void Update()
    {
        Vector3 followPos = new Vector3(transform.position.x, target.position.y + Yoffset, -10f);
        transform.position = Vector3.Lerp(transform.position, followPos, followSpeed * Time.deltaTime);
    }
}
