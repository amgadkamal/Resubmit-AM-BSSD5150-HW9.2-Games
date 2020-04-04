using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    
    public AudioSource source;

    public float[] samples = new float[1024];
  
    public int[] tenSamples = new int[100];


    void Start()
    { source.GetComponent<AudioSource>();
    }

    void Update()
    {
        
        source.GetSpectrumData(samples, 0, FFTWindow.Hanning);
        for(int i = 0; i < tenSamples.Length; i++)
        {
            tenSamples[i] = (int)(samples[i]*100);
        }
    }
}
