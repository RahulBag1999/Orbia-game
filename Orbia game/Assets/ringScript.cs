using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringScript : MonoBehaviour
{
    public Transform targetRing;
    [SerializeField] private float rotationSpeed;


    private void Update()
    {
        transform.Rotate(0, 0, 1 * rotationSpeed * Time.deltaTime);
    }
}
