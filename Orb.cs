// Created by : Julie Jacobson
// Created on : 11-05-2020
// Updated on : 12-09-2020
// Script for orb interactables


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio; 

public class Orb : MonoBehaviour
{
    // public Text text;
    public int orbValue = 1;
    public AudioSource sound;


    private bool collided;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);

    }


    private void OnTriggerEnter2D(Collider2D player) {
        if(player.gameObject.tag == "Player") {
            gameObject.SetActive(false);
            OrbsLeft.instance.ChangeOrbs(orbValue);
            sound.Play();
        }
        
    }

}
