using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuertePlayer : MonoBehaviour
{
    VidaPlayer playerVida;
    Vector3 spawn;
    CharacterController CHc;
    //Start is called before the first frame update
    void Start()
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<VidaPlayer>();
        spawn = new Vector3(0.5f, 2f, -45f);
        CHc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //void OnTriggerEnter(Collider other)
    //{
    //    if(other.tag == "Enemy")
    //    {
    //        CHc.enabled = false;
    //        transform.position = spawn;
    //        CHc.enabled = true;

    //    }
    //    if (other.tag == "Plane")
    //    {
    //        CHc.enabled = false;
    //        transform.position = spawn;
    //        CHc.enabled = true;
    //    }
    //}
    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Enemy" && playerVida.vida == 0)
        {
            CHc.enabled = false;
            transform.position = spawn;
            CHc.enabled = true;
        }
        if (col.gameObject.tag == "Plane")
        {
            CHc.enabled = false;
            transform.position = spawn;
            CHc.enabled = true;
        }
    }
 

}
