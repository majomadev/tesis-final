using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 pos;
    float horizontal;
    float vertical;
    float mouseX;
    [SerializeField]float velocidad = 30;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        pos.x = horizontal;        
        pos.z = vertical;
        mouseX = Input.GetAxis("Mouse X");        
        //transform.eulerAngles = transform.eulerAngles - new Vector3(transform.rotation.x, mouseX, transform.rotation.z);
    }

    private void FixedUpdate()
    {
        rb.velocity = pos.normalized * velocidad;
    }
    
}
