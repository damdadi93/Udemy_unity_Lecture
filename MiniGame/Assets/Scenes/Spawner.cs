using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject wallPrefab;
    public float interval = 1.5f; //���� �ð�����
    public float range = 3f;
    float term;

    void Start()
    {
        term = interval;    //���ۺ��� ���� ������ ����
    }

   
    void Update()
    {
        term += Time.deltaTime;
        if(term >= interval) //���� �ð��� ������
        {
            Instantiate(wallPrefab, transform.position
                                    ,transform.rotation);
            term -= interval;

        }
        
    }
}
