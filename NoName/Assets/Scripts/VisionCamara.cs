using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionCamara : MonoBehaviour
{
    public float SensibilidadMouse = 200f;

    public Transform CuerpoPersonaje;


    float RotacionX = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * SensibilidadMouse * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * SensibilidadMouse * Time.deltaTime;

        RotacionX -= mouseY;
        RotacionX = Mathf.Clamp(RotacionX, -90, 90);

        transform.localRotation = Quaternion.Euler(RotacionX, 0f, 0f);
        CuerpoPersonaje.Rotate(Vector3.up * mouseX);
    }
}
