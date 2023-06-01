using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public CharacterController Controlador;

    public float velocidad = 10f;
    public float gravedad = 10f;

    public Transform detectorSuelo;
    public float distanciaSuelo = 0.4f;
    public LayerMask Suelo;

    Vector3 velocity;
    bool EnElSuelo;

    // Update is called once per frame
    void Update()
    {

        //EnElSuelo = Physics.CheckSphere(detectorSuelo.position, distanciaSuelo, Suelo);

        //if(EnElSuelo && velocity.y < 0)
        //{
        //    velocity.y = 0;
        //}


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movimiento = transform.right * x + transform.forward * z;

        Controlador.Move(movimiento * velocidad * Time.deltaTime);

        velocity.y -= gravedad * Time.deltaTime;
        Controlador.Move(velocity * Time.deltaTime);
       
    }
}
