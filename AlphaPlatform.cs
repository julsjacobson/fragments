// Created by : Julie Jacobson
// Created on : 12-09-2020
// Updated on : 12-09-2020
// Script to make platforms transparent

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class AlphaPlatform : MonoBehaviour
{
    private bool removePlatform; 
    SpriteRenderer renderer;

    void Start()
    {
        renderer  = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B)) removePlatform = !removePlatform;

        if (removePlatform) renderer.material.color = new Color(1f, 1f, 1f, .5f);
        else renderer.material.color = new Color(1f, 1f, 1f, .9f);

    }
}
