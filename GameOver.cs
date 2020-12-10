// Created by : Julie Jacobson
// Created on : 11-05-2020
// Updated on : 12-09-2020
// When player falls off platform

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndLevel : MonoBehaviour
{
    // public variables
    public float minimum = 0.0f;
    public float maximum = 1f;
    public float duration = 5.0f;
    public Animator bg;
    public Animator p;
    public Text text;


    // private variables
    private float startTime;
    private bool collided =false;

    void Start()
    {
        text.gameObject.SetActive(false);
    }

    void Update()
    {
        float t = (Time.time - startTime) / duration;

        if (collided) {
            bg.SetBool("fadeout",  true);
            p.SetBool("falling", true);
            text.color = new Color(1f, 1f, 1f, Mathf.SmoothStep(minimum, maximum, t));

            if (Input.GetKey(KeyCode.Space)) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D player) {
        if(player.gameObject.tag == "Player") {
            startTime = Time.time;

            Debug.Log("hit");
            text.gameObject.SetActive(true);
            collided = true;
        }
        
    }
}
