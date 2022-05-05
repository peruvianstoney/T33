using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform background;
    public Transform playerTransform;

    void Start()
    {
        
    }

    void Update()
    {
        var x = playerTransform.position.x + 11;
        var y = playerTransform.position.y + 2;
        transform.position = new Vector3(x,y,transform.position.z);
        background.position = new Vector3(transform.position.x, transform.position.y, background.position.z);
    
    }
}

