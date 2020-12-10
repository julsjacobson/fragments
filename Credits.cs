using System.Collections;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 using UnityEngine.UI;
// Created by : Julie Jacobson
// Created on : 12-09-2020
// Updated on : 12-09-2020
// Used for game credits
 
 public class Credits : MonoBehaviour
 {
    public Text txt; 
    public float delay;
    
     void Start()
     {
        txt.text = "All fragments have been restored\nThank you";
        StartCoroutine(LoadLevelAfterDelay(delay));
     }
 
     IEnumerator LoadLevelAfterDelay(float delay)
     {
        yield return new WaitForSeconds(delay);
        txt.text = "Artist & Designer....................Meghan Landry\nProducer & Programmer................Julie Jacobson";
        yield return new WaitForSeconds(delay);
        txt.fontSize = 10;
        txt.text = "Music\nPeritune - Melancholy 3\nPeritune - Whisper 3\nPeritune - Gentle\nPertiune - Wish 4\nSource: http://peritune.com"
                    + "\n\nSounds\nMystic Spill by Robinhood76 \nhttps://freesound.org/people/Robinhood76/sounds/488327/\nRunning A.wav by InspectorJ \nwww.jshaw.co.uk\nSparkle by Soughtaftersounds \nhttps://freesound.org/people/Soughtaftersounds/sounds/145459/\n"
                    + "\nAll sounds and music used under Creative Commons License \nhttps://creativecommons.org/licenses/by-nc/3.0/";
        yield return new WaitForSeconds(delay);
        txt.fontSize = 20;
        txt.text = "Thank you";

     }
 }