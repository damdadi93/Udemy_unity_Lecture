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
                //���̻� ���ǹ��� �������� �ʵ��� �������̿�
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //�浹�� ����� ������ �����´�.
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
