using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSpawn : MonoBehaviour
{
    public GameObject swanSpot;
    public GameObject dropObject;
    public BoxCollider rangeColider;


    //공 생성 지연
    public float interval = 50f;
    public float range = 10f;
    public float delay = 5f;
    public float countTime;


    float term;

    void Start()
    {
        rangeColider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(Drop());
        //StopCoroutine(Drop());

        //pos.x = Random.Range(0, range);

        //if (Random.Range(0, 2)==0) 
        //{ 
        //    Instantiate(dropObject, pos.x, Quaternion.identity);
        //}

        //Vector3 pos 

    }

    
    IEnumerator Drop()
    {

        Vector3 pos = transform.position;

        float range_x = pos.x;
        float range_y = pos.y;


        term += Time.deltaTime;

        // 하나씩 천천히 떨어지면 좋을꺼같은데 느리게 할수 있는게 있을까
        while(term >= delay)
        {
            range_x = Random.Range(-5, 5);
            //range_y = Random.Range((range_y/2) * -1, range_y/2);

            Vector3 RandomPosiotion = new Vector3(range_x, range_y, 0);

            Debug.Log("값:" + range_x);

            yield return new WaitForSeconds(interval * Time.deltaTime);

            Instantiate(dropObject, RandomPosiotion, transform.rotation);
            
            term -= interval*Time.deltaTime;
        }


    }


}
