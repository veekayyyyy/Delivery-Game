using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingtofollow;
    
    // this thing positions (the camera ) should be same as the cars position

    void Update()
    {
        transform.position = thingtofollow.transform.position + new Vector3 (0,0,-10);
        
    }
}
