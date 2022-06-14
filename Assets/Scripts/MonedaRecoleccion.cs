using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaRecoleccion : MonoBehaviour
{
    AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
           Audio.Play();
           // gameObject.SetActive(false);
           Destroy(gameObject,0.5f);
        }
       
       
    }
}
