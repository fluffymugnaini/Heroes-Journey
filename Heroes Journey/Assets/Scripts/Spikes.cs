﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{

   private Player player;
    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Player>();
        
    }

    void OnTriggerEnter2D(Collider2D col){
       if(col.CompareTag("Player")){
          player.Damage(100);
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
