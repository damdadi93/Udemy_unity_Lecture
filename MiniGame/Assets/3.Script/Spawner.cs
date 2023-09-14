using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] wallPrefab;
    public GameObject dropPrefab;

    public GameObject backGroundPrefab;

    public float interval = 1.5f; //일정 시간마다
    //배경
    public float backGroundTime = 2f;
    public float range = 3f;
    float term;
    //배경
    float backGroundTerm;

    void Start()
    {
        term = interval;    //시작부터 벽이 나오기 위해
    }

   
    void Update()
    {
        term += Time.deltaTime;
        backGroundTerm += Time.deltaTime;
        if(term >= interval) //일정 시간이 지나면
        {
            Vector3 pos = transform.position;
            pos.y += Random.Range(-range, range); //Range 랜덤 함수

            //프리팹 자동생성함수 
            int wallType = Random.Range(0, wallPrefab.Length);
            Instantiate(wallPrefab[wallType], pos//transform.position //pos로 받는다.
                                                 ,transform.rotation);

            if (Random.Range(0, 2) == 0) //50%의 확률로
                Instantiate(dropPrefab); // 떨어지는 장애물 생성
            

            term -= interval;


        }

        //배경
        if (backGroundTerm >= backGroundTime)
        {
            
            Instantiate(backGroundPrefab, backGroundPrefab.transform.position, backGroundPrefab.transform.rotation);

            backGroundTerm %= backGroundTime;
        }
            

    }
}
