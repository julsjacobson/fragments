// Created by : Julie Jacobson
// Created on : 12-09-2020
// Updated on : 12-09-2020
// Destroys music from previous level

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public string destroyTag = "";
    
    void Start() {        
        GameObject obj = GameObject.FindWithTag(destroyTag);
        Destroy(obj);
    }

}
