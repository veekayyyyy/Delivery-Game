using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MYCARPROJECT : MonoBehaviour
{
    [SerializeField] float steerspeed = 200f;
    [SerializeField] float movespeed = 15f;
    [SerializeField] float slowspeed = 10f;
    [SerializeField] float boostspeed = 30f;

    
    // Update is called once per frame
    void Update()
    {
        float steeramount= Input.GetAxis("Horizontal") * steerspeed * Time.deltaTime;
        float speedamount= Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        transform.Rotate(0, 0, -steeramount);
        transform.Translate(0, speedamount ,0);
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        movespeed=slowspeed;
        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Boost"){
            Debug.Log(" you are boosting your car speed man");
            movespeed = boostspeed ;
        }
        
    }
}
