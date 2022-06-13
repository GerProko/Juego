using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class Prueba : MonoBehaviour
{
    public GameObject ganaste;
    public FirstPersonController fps;

    // Start is called before the first frame update
    void Start()
    {
        fps.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
        ganaste.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
