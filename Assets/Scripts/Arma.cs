using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawn = null;
    public float reloadTime;
    //public float inacuracy;
    float currReloadTime;
    //bool canShoot = true;
    AudioSource Audio2;
    void Start()
    {
        currReloadTime = reloadTime;
        Audio2 = GetComponent<AudioSource>();

    }
    void Update()
    {
        if (currReloadTime > 0)
        {
            currReloadTime -= Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && currReloadTime <= 0)
        {
            
            var b = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
            currReloadTime = reloadTime;
            Audio2.Play();
        }
        
    }
}
