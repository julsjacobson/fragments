// Created by : Julie Jacobson
// Created on : 11-20-2020
// Updated on : 12-09-2020
// Switches between scenes after time delay

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public float delay = 0;
    public string NewLevel= "";
    
    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
        
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(NewLevel);
    }
}