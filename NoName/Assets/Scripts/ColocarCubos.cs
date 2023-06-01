using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColocarCubos : MonoBehaviour
{
    [SerializeField] private Material ColorZonaVerde;
    [SerializeField] private Material ColorZonaAmarillo;
    public void Start()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.CompareTag("Interactuables"))
        {
            Debug.Log("Se coloco el cubo");
            //ColorZona.color = Color.green;
            transform.gameObject.GetComponent<MeshRenderer>().material = ColorZonaVerde;
        }
        else
        {
            transform.gameObject.GetComponent<MeshRenderer>().material = ColorZonaAmarillo;
        }
       
    }
}
