using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //physical power add
    //"float" is 실수 자료형(data tyPe)
    public float jumpPower = 5f;
    TextMesh scoreOutput;
    int score = 0;

    void Start()
    {
        scoreOutput = GameObject.Find(name: "Score").GetComponent<TextMesh>();
            //이름으로 게임 오브젝트를 찾고, 그중 TextMesh컴포너트를 얻기
    }

    
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
    }

    //SceneManager needs a namespace "UnityEngine.SceneManagement"
    private void OnCollisionEnter(Collision collision) //collision은 박스콜라이더컴포넌트에서 
    {
        //GetActiveScene() 문자열 타입이 들어가야한다.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //점수더하기
    public void addScore(int s)
    {
        score += s;
        scoreOutput.text = "Score : " + score;
    }

}
