﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag == "Ground") {
            Player.GetComponent<PlayerController>().isGrounded = true;
        }
        
    }
    

    private void OnTriggerExit2D(Collider2D collider) {
        if(collider.gameObject.tag == "Ground") {
            Player.GetComponent<PlayerController>().isGrounded = false;
        }
        
    }
}
