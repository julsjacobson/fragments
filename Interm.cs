// Created by : Julie Jacobson
// Created on : 11-20-2020
// Updated on : 12-09-2020
// Script to controll intermission scenes

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interm : MonoBehaviour
{
    public float delay = 2;
    public GameObject character;
    public GameObject character2;
    public AudioSource sound;


    void Start()
    {
        character.SetActive(true);
        character2.SetActive(false);
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        character.SetActive(false);
        character2.SetActive(true);
        sound.Play();
    }
}