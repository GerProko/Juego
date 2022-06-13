using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformanivel3 : MonoBehaviour
{
    bool movimiento = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movimiento == true)
        {
            transform.position += new Vector3(0, 0.1f, 0);
        }
        else
        {
            transform.position -= new Vector3(0, 0.1f, 0);
        }
        if (transform.position.y > 13)
        {
            movimiento = false;
        }
        if (transform.position.y < 2.5f)
        {
            movimiento = true;
        }
    }
}
