// Created by : Julie Jacobson
// Created on : 11-05-2020
// Updated on : 12-09-2020
// Typewriter effect for text objects

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour
{
    private float delay = 0.075f;
    public float startTime;
    public string fullText;
    private string currentText = "";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowText());
    }

    void Update() {


    }

    IEnumerator ShowText() {
        yield return new WaitForSeconds(startTime);
        for (int i = 0; i < fullText.Length; i++) {
            currentText = fullText.Substring(0,i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }


}
