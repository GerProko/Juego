﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    public int hp = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DamageEnemy()
    {
        hp--;

        if (hp >= 0)
        {
            Destroy(gameObject);
        }
    }
}