using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = -5f;
    public float interval = 10f;
    public GameObject back;

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
            Vector3 pos =transform.position;
            Instantiate(back, pos, transform.rotation);
            term -= interval;
        }



        transform.Translate(speed * Time.deltaTime, 0, 0);
        

                   
            
        
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
    }
}
