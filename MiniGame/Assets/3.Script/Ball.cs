using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //속도 줄이기
    public GameObject objectBall;
    public Rigidbody rigidBody;

    public bool hit = false;
    public float reduceTime = 1f;
    public float term;


    // Start is called before the first frame update
    void Start()
    {
        
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        term += Time.deltaTime;
        if(term >= reduceTime)
        {
            rigidBody.useGravity = false;
            term -=Time.deltaTime;
        }
        else
            rigidBody.useGravity=true;

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        hit = true;
        if (hit == true && collision.gameObject.GetComponent<Frame>() != null)
        {
            Destroy(gameObject);
        }
    }


}
