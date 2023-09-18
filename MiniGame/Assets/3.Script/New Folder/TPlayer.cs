using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TPlayer : MonoBehaviour
{
    public float Speed =10.0f;
    public Collider Col;
    //충돌판정
    public bool hit = false;
    public int life =3;
    

    // Start is called before the first frame update
    void Start()
    {
        Col = GetComponent<Collider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float translate = Input.GetAxis("Horizontal") * Speed;
        
        translate *= Time.deltaTime;

        transform.Translate(translate, 0, 0);
    
    }

    private void OnCollisionEnter(Collision collision)
    {
        hit = true;
        
        if (hit == true)
        {
            life -= 1;
        }
        if (life == 0 && hit == true && collision.gameObject.GetComponent<Ball>() != null)
        {
            
            
            Debug.Log("충돌");
            Debug.Log("충돌횟수:" + life);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }






}
