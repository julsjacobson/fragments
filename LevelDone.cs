// Created by : Julie Jacobson
// Created on : 11-05-2020
// Updated on : 12-09-2020
// Actions when level finishes

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Level1Done : MonoBehaviour
{

    public Text text;
    public int orbs;
    private float delay = 0.05f;
    public string fullText;
    private string currentText = "";
    private bool done = false;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowText());
    }

    // Update is called once per frame
    void Update()
    {
        if (OrbsLeft.instance.GetOrbs() == orbs) {
            done = true;
            if(text) Destroy(text, 7);
        }
    }

    IEnumerator ShowText() {

        while(!done) {
            yield return null;
        }
        for (int i = 0; i < fullText.Length; i++) {
            currentText = fullText.Substring(0,i);
            text.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }


}
