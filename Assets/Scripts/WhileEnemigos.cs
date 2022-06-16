using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileEnemigos : MonoBehaviour
{
    bool movimiento = true; 
    // Start is called before the first frame update
    void Start()
    {
        while (movimiento == true)
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }
        while (movimiento == false)
        {
            transform.position -= new Vector3(0.1f, 0, 0);
        }
        if (transform.position.x > 2.6f)
        {
            movimiento = false;
        }
        if (transform.position.x < -2)
        {
            movimiento = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
