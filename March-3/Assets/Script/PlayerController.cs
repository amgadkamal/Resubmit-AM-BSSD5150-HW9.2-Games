using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables
    public GameObject audSour;
    private int[] audioData;
    public GameObject bad1;
    public GameObject bad2;
    public GameObject bad3;
    public GameObject bad4;
    public GameObject bad5;
  
   


    void Start()
    {
        audioData = audSour.GetComponent<AudioController>().tenSamples;
    }

   
    void Update()
    {
       
        int audioArrayIdx = 0;
        GameObject[] badguys = new GameObject[] { bad1, bad2, bad3, bad4,bad5};
        
        
        foreach (GameObject badguy in badguys)
        {

            Debug.Log(audioData[audioArrayIdx]);
           

            if ((audioData[audioArrayIdx] % 2) == 0 && audioData[audioArrayIdx] != 0)

            {
               
                badguy.SetActive(false);
            }
            
            else if ((audioData[audioArrayIdx] % 2) == 1)

            {
                badguy.SetActive(true);
            }
            
            
            audioArrayIdx++;
            
        }
    }

     
}
