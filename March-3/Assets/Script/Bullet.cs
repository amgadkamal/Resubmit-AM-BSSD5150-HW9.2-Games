using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] 
    private Transform FirePosition;

    GameObject bullet;
    private Rigidbody2D rb;

    private float bullets=10f;
    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent<Rigidbody2D>();    
    bullet=Instantiate(Resources.Load("bullet"), FirePosition.position, Quaternion.identity) as GameObject;
    bullet.SetActive(false);
    
    
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!bullet.activeSelf)
            {
                bullet.transform.position = FirePosition.transform.position;
                bullet.SetActive(true);

            }

        }
    }


    private void OnBecameInvisible()
    {
        this.gameObject.SetActive(false);
    }

    private void OnBecameVisible()
    {
        rb.velocity=Vector2.right*bullets;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    
    { if (collision.gameObject.tag == "enemyM") {
            Destroy(GameObject.FindWithTag("enemyM")); } 
    
     if (collision.gameObject.tag == "enemyJ") {
        Destroy(GameObject.FindWithTag("enemyJ"));  }

     if (collision.gameObject.tag == "enemyF")
     {
         Destroy(GameObject.FindWithTag("enemyF"));
     }
     
     if (collision.gameObject.tag == "enemyD")
     {
         Destroy(GameObject.FindWithTag("enemyD"));
     }
     
     if (collision.gameObject.tag == "enemy")
     {
         Destroy(GameObject.FindWithTag("enemy"));
     }
    }
}
