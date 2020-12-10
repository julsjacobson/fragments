// Created by : Julie Jacobson
// Created on : 11-05-2020
// Updated on : 12-09-2020
// Script to control spirit fragment

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Spirit : MonoBehaviour
{
    // public variables 
    public Text text; // text before orbs are collected
    public Text afterText; // text after all orbs are collected
    public string NextScene; // next scene to go to
    public Animator animator; // begins fade out animation
    public int orbs; // how many orbs in the specific scene


    // private variables
    private bool collided;
    private bool orbsCollected;
    private bool done;

    
    // Start is called before the first frame update
    void Start()
    {
        done = false;

        text.gameObject.SetActive(false);
        afterText.gameObject.SetActive(false);
        transform.localScale = new Vector3(1f, 1f, 1f); // sets the size of the spirit

    }

    // Update is called once per frame
    void Update()
    {
        if (OrbsLeft.instance.GetOrbs() == orbs) {

            text.gameObject.SetActive(false);
            if(collided) afterText.gameObject.SetActive(true);

            orbsCollected = true;
            if (collided && Input.GetKeyDown(KeyCode.E)) {
                afterText.gameObject.SetActive(false);

                animator.SetBool("fadeout", true);
                transform.localScale = new Vector3(0f, 0f, 0f); // scales to 0 so the object is destroyed or inactive so coroutine may begin

                StartCoroutine(FadeOut());
            }

        }


    }

    private void OnTriggerEnter2D(Collider2D player) {
        if(player.gameObject.tag == "Player") {
            text.gameObject.SetActive(true);
            collided = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D player) {
        if(player.gameObject.tag == "Player" && !orbsCollected) {
            text.gameObject.SetActive(false);
            collided = false;
        }
        
    }


     IEnumerator FadeOut() {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene(NextScene);


    }

}
