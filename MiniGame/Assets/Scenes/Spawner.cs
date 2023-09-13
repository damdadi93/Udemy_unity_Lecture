using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject wallPrefab;
    //public GameObject movePrefab;
    public float interval = 1.5f; //일정 시간마다
    public float range = 3f;
    float term;

    void Start()
    {
        term = interval;    //시작부터 벽이 나오기 위해
    }

   
    void Update()
    {
        term += Time.deltaTime;
        if(term >= interval) //일정 시간이 지나면
        {
            Vector3 pos = transform.position;
            pos.y += Random.Range(-range, range); //Range 랜덤 함수

            //프리팹 자동생성함수 
            Instantiate(wallPrefab, pos//transform.position //pos로 받는다.
                                    ,transform.rotation);
            term -= interval;

        }
        
    }
}
