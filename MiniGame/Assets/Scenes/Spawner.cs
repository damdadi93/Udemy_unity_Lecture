using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject wallPrefab;
    //public GameObject movePrefab;
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
            Vector3 pos = transform.position;
            pos.y += Random.Range(-range, range); //Range ���� �Լ�

            //������ �ڵ������Լ� 
            Instantiate(wallPrefab, pos//transform.position //pos�� �޴´�.
                                    ,transform.rotation);
            term -= interval;

        }
        
    }
}
