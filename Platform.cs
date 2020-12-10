// Created by : Julie Jacobson
// Created on : 12-09-2020
// Updated on : 12-09-2020
// Script to inactivate certain platforms

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class Platform : MonoBehaviour
{
    private bool removePlatform; 
    public GameObject platforms;

    void Start()
    {
        platforms.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B)) removePlatform = !removePlatform;

        if (removePlatform) platforms.SetActive(false);
        else platforms.SetActive(true);

    }
}
