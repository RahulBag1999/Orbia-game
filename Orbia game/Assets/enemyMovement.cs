using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    
    void Update()
    {
        transform.Rotate(0, 0, 1 * rotationSpeed);
    }
}