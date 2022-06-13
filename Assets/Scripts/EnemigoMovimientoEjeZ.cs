using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMovimientoEjeZ : MonoBehaviour
{
    bool movimiento = true;
   
    public float z;
    public float z2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        if (movimiento == true)
        {
            transform.position += new Vector3(0, 0, 0.1f);
        }
        else
        {
            transform.position -= new Vector3(0, 0, 0.1f);
        }
        if (transform.position.z > z)
        {
            movimiento = false;
        }
        if (transform.position.z < z2)
        {
            movimiento = true;
        }
    }
}
