using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] wallPrefab;
    public GameObject dropPrefab;

    public GameObject backGroundPrefab;

    public float interval = 1.5f; //���� �ð�����
    //���
    public float backGroundTime = 2f;
    public float range = 3f;
    float term;
    //���
    float backGroundTerm;

    void Start()
    {
        term = interval;    //���ۺ��� ���� ������ ����
    }

   
    void Update()
    {
        term += Time.deltaTime;
        backGroundTerm += Time.deltaTime;
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

        //���
        if (backGroundTerm >= backGroundTime)
        {
            
            Instantiate(backGroundPrefab, backGroundPrefab.transform.position, backGroundPrefab.transform.rotation);

            backGroundTerm %= backGroundTime;
        }
            

    }
}
