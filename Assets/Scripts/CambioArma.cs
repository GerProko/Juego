using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioArma : MonoBehaviour
{
    public GameObject armaPrincipal;
    public GameObject armaSecundaria;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            armaPrincipal.SetActive(true);
            armaSecundaria.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            armaPrincipal.SetActive(false);
            armaSecundaria.SetActive(true);
        }
    }
}
