using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] wallPrefab;
    public GameObject dropPrefab;
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
            int wallType = Random.Range(0, wallPrefab.Length);
            Instantiate(wallPrefab[wallType], pos//transform.position //pos�� �޴´�.
                                                 ,transform.rotation);

            if (Random.Range(0, 2) == 0) //50%�� Ȯ����
                Instantiate(dropPrefab); // �������� ��ֹ� ����
            
            term -= interval;

        }
        
    }
}
