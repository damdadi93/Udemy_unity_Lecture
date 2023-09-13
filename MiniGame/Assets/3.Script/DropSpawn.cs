using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSpawn : MonoBehaviour
{
    public GameObject dropObject;
    public float interval = 3f;
    public float range = 5f;



    float term;

    void Start()
    {
        term = interval;
    }

    // Update is called once per frame
    void Update()
    {
        term += Time.deltaTime;
        if(term >= interval)
        {
            //Vector3 pos 
        }
    }
}
