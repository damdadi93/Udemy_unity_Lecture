using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour //MonoBehaviour is unity basic function.
{
    public float speed = -5f;
    //Use this for initialization
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

    }

   
}
