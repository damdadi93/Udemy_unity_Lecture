using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //physical power add
    //"float" is �Ǽ� �ڷ���(data tyPe)
    public float jumpPower = 5f;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
    }

}
