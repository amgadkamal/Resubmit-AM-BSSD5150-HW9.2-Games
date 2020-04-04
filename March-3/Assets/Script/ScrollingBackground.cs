using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.03f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool inputMethod = false;
        if (inputMethod)
        {
            var inputX = Input.GetAxis("Horizontal");
            var inputY = Input.GetAxis("Vertical");

            Vector2 offset = new Vector2(speed * inputX, speed * inputY);
            GetComponent<Renderer>().material.mainTextureOffset += offset;
        }

        else
        {
            Vector2 offset = new Vector2(speed * Time.time,0);
            GetComponent<Renderer>().material.mainTextureOffset = offset;
        }





    }
}
