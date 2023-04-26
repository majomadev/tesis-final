using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour

{
    private float x;
    private float y;
    private Vector3 rotateValue;    

    private void LateUpdate()
    {
        y = Input.GetAxis("Mouse X");
        x = Input.GetAxis("Mouse Y");
        Debug.Log(x + ":" + y);
        rotateValue = new Vector3(x, y * -1, 0);
        transform.eulerAngles = transform.eulerAngles - rotateValue;
    }
}
