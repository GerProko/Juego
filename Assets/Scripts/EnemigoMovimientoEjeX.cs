using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMovimientoEjeX : MonoBehaviour
{
    bool movimiento = true;

    public float x;
    public float x2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (movimiento == true)
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(0.1f, 0, 0);
        }
        if (transform.position.x > x)
        {
            movimiento = false;
        }
        if (transform.position.x < x2)
        {
            movimiento = true;
        }
    }
}
