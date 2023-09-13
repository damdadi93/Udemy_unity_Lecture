using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject wallPrefab;
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
            Instantiate(wallPrefab, transform.position
                                    ,transform.rotation);
            term -= interval;

        }
        
    }
}
