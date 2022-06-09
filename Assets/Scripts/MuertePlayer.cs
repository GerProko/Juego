using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuertePlayer : MonoBehaviour
{
    public GameObject jugador;
    Vector3 spawn;
    //Start is called before the first frame update
    void Start()
    {
        spawn = new Vector3(0.5f, 2f, -45f);
    }

    // Update is called once per frame
    void Update()
    {

    }
     void OnTriggerEnter(Collider other)
     {
         if(other.tag == "Enemy")
         {
             transform.position = spawn;
             Debug.Log("Hola");

         }
        if (other.tag == "Plane")
        {
            transform.position = spawn;
            Debug.Log("Hola");

        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            transform.position = spawn;
            Debug.Log("Hola");

        }

    }
}
