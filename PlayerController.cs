// Created by : Julie Jacobson
// Created on : 11-05-2020
// Updated on : 12-09-2020
//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour {
    // public variables
    public float speed;
    public float jumpForce;
    public GameObject minimapCam;
    public AudioSource running;
    public SpriteRenderer sr;
    public Animator animator; 
    public bool isGrounded = true;





    // private variables
    private bool doubleJumped;
    private bool canDoubleJump;
    private bool minimapShow;


    private Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();

        if (SceneManager.GetActiveScene().name == "Level3" || SceneManager.GetActiveScene().name == "Level4") canDoubleJump = true;
 

        minimapShow = false;

    }
    void Update() {
        if(Input.GetKeyDown(KeyCode.M)) minimapShow = !minimapShow;

        // play running sound
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow)) running.Play();
        else if (Input.GetKeyUp(KeyCode.LeftArrow)) running.Stop();
        else if (Input.GetKeyUp(KeyCode.RightArrow)) running.Stop();
        else if (!isGrounded) running.Stop();
        

    }

    void FixedUpdate() {
        Jump();
        float movement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movement * speed, rb.velocity.y);

        if(movement != 0) {
            animator.SetFloat("movementSpeed", Mathf.Abs(movement));
        }
        else {
            animator.SetFloat("movementSpeed", 0);
        }

        // flip sprite
        if (movement > 0) sr.flipX = false;
        else if (movement <0) sr.flipX = true;

        // show minimap
        if(minimapShow) minimapCam.SetActive(true);
        else minimapCam.SetActive(false);
    }

    void Jump() {

        if (isGrounded) {
            doubleJumped = false;
            animator.SetBool("jump",false);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            if (isGrounded) {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                animator.SetBool("jump", true);
                isGrounded = false;

            } else {
                if(!doubleJumped && canDoubleJump) {
                    gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                    doubleJumped = true; 
                    animator.SetBool("jump", true);
                }
            }
            
        }  

        // turn off jump animation
        if (rb.velocity.y == 0) {
            animator.SetBool("jump", false);
            isGrounded = true;
        }


    }


}