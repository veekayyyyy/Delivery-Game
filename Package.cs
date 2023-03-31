using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor= new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor= new Color32(1,1,1,1);


    [SerializeField] float destroydelay= 0.2f;
    bool package = false;

    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer= GetComponent<SpriteRenderer>();
    }


    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log(" your car bumped into an object !!!! ") ;       
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        

        if( other.tag == "Package" && package==false)
        {
            Debug.Log(" the package is picked ");
            package = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroydelay);
        }        
        if( other.tag == "Delivery"  && package )
        {
            Debug.Log(" the package is delivered");
            package= false;
            spriteRenderer.color = noPackageColor;
          
        }
    }
}
