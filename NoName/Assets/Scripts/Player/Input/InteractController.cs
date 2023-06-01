using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractController : MonoBehaviour
{
    GameObject jugador, objetoMano;
    //[SerializeField] private float distanciaRayo = 100f;
    [SerializeField] private float distanciaInteractuable;
    [SerializeField] private GameObject Mano;
    private bool cargandoObj;
    Camera cam;
    Animator anim;

    [SerializeField] private Material BotonApagado;
    [SerializeField] private Material BotonPrendido;
   // [SerializeField] private GameObject Boton;

    bool BotonOn = false;

    private void Start()
    {
        //anim = GameObject.Find("Palanca").GetComponent<Animator>();
        objetoMano = null;
        cam = Camera.main;
        jugador = GameObject.FindGameObjectWithTag("Player");
       // Boton.gameObject.GetComponent<MeshRenderer>().material = BotonApagado;

    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && !cargandoObj)
        {
            RaycastHit hit;            
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
            {
                if (Vector3.Distance(transform.position, hit.collider.transform.position) < distanciaInteractuable && !cargandoObj)
                {
                    if (hit.transform.CompareTag("Interactuables"))
                    {
                        objetoMano = hit.transform.gameObject;
                        objetoMano.GetComponent<Rigidbody>().isKinematic = true;
                        objetoMano.transform.position = Mano.transform.position;
                        objetoMano.transform.SetParent(Mano.transform);
                        cargandoObj = true;
                    }
                    if (hit.transform.CompareTag("Palanca"))
                    {
                        anim.SetTrigger("Accionar");
                    }
                    if (hit.transform.CompareTag("Boton"))
                    {
                        if(BotonOn == false)
                        {
                            hit.transform.gameObject.GetComponent<MeshRenderer>().material = BotonPrendido;
                            Debug.Log("se presiono el boton");
                            BotonOn = true;
                        }
                        else
                        {
                           // Boton.gameObject.GetComponent<MeshRenderer>().material = BotonApagado;
                            BotonOn = false;
                        }
                        
                    }

                }
            }
        }
        else if (Input.GetButtonUp("Fire1") && cargandoObj)
            {               
                objetoMano.transform.SetParent(null);
                objetoMano.GetComponent<Rigidbody>().isKinematic = false;
                cargandoObj = false;                
            
            }


    }
}
