using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour //MonoBehaviour is unity basic function.
{
    public float speed = -5f;
    public float Movespeed = 5f;
    public float Moverange = 3f;
    float term;
    public Rigidbody rb;
    Player player;


    //Use this for initialization
    void Start()
    {
        player = GameObject.Find(name: "Player").GetComponent<Player>();
    }

    
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        transform.Translate(Movespeed * Time.deltaTime, 0, 0);
        Vector3 pos = transform.position;
        pos.y += Random.Range(-Moverange, Moverange);

        //rb.MovePosition(transform.position + (pos.y * Time.deltaTime * Movespeed));

        if(transform.position.x < -10)
        {
            Destroy(gameObject);
            player.addScore(1);
        }
           

    }

   
}
