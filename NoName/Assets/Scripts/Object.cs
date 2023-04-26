using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public string name;
    [SerializeField]GameObject UI;
    [SerializeField] TMPro.TMP_Text texto;

    private void OnCollisionEnter(Collision collision)
    {
        UI.SetActive(true);
        UI.LeanScale(Vector3.one,0.2f).setEaseLinear();
    }

    private void OnCollisionExit(Collision collision)
    {        
        UI.LeanScale(Vector3.zero, 0.2f).setEaseLinear();
        UI.SetActive(false);
    }
}
