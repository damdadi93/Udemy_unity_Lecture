using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundSensor : MonoBehaviour
{   

    public float bgSpeed = -5f;
    public GameObject spawnBackground;

    [SerializeField]
    private BoxCollider Box;

    bool spawnSensor = false;

    // Start is called before the first frame update
    void Start()
    {
        Box = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {



    }

    private void OnTriggerEnter(Collider other)
    {
        spawnSensor = true;
        //Box.isTrigger = true;
        
    }

    private void OnTriggerStay(Collider other)
    {
        

    }

    private void OnTriggerExit(Collider other)
    {
        //Box.isTrigger = false;
        
        Destroy(spawnBackground);
    }


}
