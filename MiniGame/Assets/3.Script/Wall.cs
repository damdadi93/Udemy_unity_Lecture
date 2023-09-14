using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour //MonoBehaviour is unity basic function.
{
    public float speed = -5f;
    Player player;
    
    


    //Use this for initialization
    void Start()
    {
        player = GameObject.Find(name: "Player").GetComponent<Player>();
       
    }
    
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if(transform.position.x < -10)
        {
            Destroy(gameObject);
            player.addScore(1);
        }
        
    }

   
}
