// Created by : Julie Jacobson
// Created on : 12-09-2020
// Updated on : 12-09-2020
// Used for game credits

using System.Collections;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 
 public class End : MonoBehaviour
 {
     public float delay = 0;
     public GameObject character;
     public GameObject character2;
     public GameObject character3;
     public GameObject character4;


     void Start()
     {
        character.SetActive(true);
        character2.SetActive(false);
        character3.SetActive(false);
        character4.SetActive(false);
        StartCoroutine(LoadLevelAfterDelay(delay));
     }
 
     IEnumerator LoadLevelAfterDelay(float delay)
     {
        yield return new WaitForSeconds(delay);
        character.SetActive(false);
        character2.SetActive(true);
        character3.SetActive(false);
        character4.SetActive(false);
        yield return new WaitForSeconds(delay);
        character.SetActive(false);
        character2.SetActive(false);
        character3.SetActive(true);
        character4.SetActive(false);
        yield return new WaitForSeconds(delay);
        character.SetActive(false);
        character2.SetActive(false);
        character3.SetActive(false);
        character4.SetActive(true);


     }
 }