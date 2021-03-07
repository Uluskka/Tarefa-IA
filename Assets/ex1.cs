using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1: MonoBehaviour
{


    
    void Start()
    {

    }

    
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(1, 1, 2), Time.deltaTime);
    }
}