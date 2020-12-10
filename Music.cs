// Created by : Julie Jacobson
// Created on : 12-09-2020
// Updated on : 12-09-2020
// Script to play music seamlessly through scenes

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public string tag = "";

    private void Awake() {        
        GameObject[] objs = GameObject.FindGameObjectsWithTag(tag);
        if(objs.Length > 1) Destroy(this.gameObject);

        DontDestroyOnLoad(transform.gameObject);

    }


}
