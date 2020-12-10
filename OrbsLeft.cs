// Created by : Julie Jacobson
// Created on : 11-05-2020
// Updated on : 12-09-2020
// Keeps track of how many orbs left in the scene


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrbsLeft : MonoBehaviour
{
    public static OrbsLeft instance;
    public Text txt;
    private int orbs;
    public int numOrbs;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null) instance = this;
    }

    public void ChangeOrbs(int value)
    {
        orbs += value;
        txt.text = "fragments collected: " + orbs.ToString() + "/" + numOrbs;
    }

    public int GetOrbs() {
        return orbs;
    }
}
