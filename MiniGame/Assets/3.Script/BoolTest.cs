using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolTest : MonoBehaviour
{
    bool check;


    // Start is called before the first frame update
    void Start()
    {
        check = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<0)
        {
            if(!check)
            {

                check=true;
                //더이상 조건문을 실행하지 않도록 참거짓이용
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //충돌한 대상의 정보를 가져온다.
        if(collision.gameObject.name == "BackGround")
        {

        }
        if(collision.gameObject.GetComponent<Wall>() != null)
        {
            if(collision.gameObject.CompareTag("Wall"))
            {

            }
        }
    }


}
