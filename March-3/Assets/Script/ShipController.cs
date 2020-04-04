using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShipController : MonoBehaviour
{
    
    [SerializeField] 
    private Transform FirePosition;
    
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var inputX = Input.GetAxis("Horizontal");
        var inputY = Input.GetAxis("Vertical") ;

        
        rb.rotation += inputY ;
        rb.velocity = gameObject.transform.up * inputX;
     
        
    }
    private void OnTriggerEnter2D(Collider2D collision)                                                                 
    {                                                                                                                   
        if (collision.gameObject.tag == "earth")                                                                         
        {                                                                                                               
            SceneManager.LoadScene("Earth"); 
        }                                                                                                               
    }  
    
  
               


               
      
}
