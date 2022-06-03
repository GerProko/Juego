using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoEspada : MonoBehaviour
{
    //public string enemy;
    public bool atacando = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           atacando = true;
            Debug.Log("Ataque");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" && atacando)
        {
            other.gameObject.GetComponent<VidaEnemigo>().DamageEnemy();
            Debug.Log("-1hp");
        }
    }
}
