using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //physical power add
    //"float" is �Ǽ� �ڷ���(data tyPe)
    public float jumpPower = 5f;
    TextMesh scoreOutput;
    int score = 0;

    void Start()
    {
        scoreOutput = GameObject.Find(name: "Score").GetComponent<TextMesh>();
            //�̸����� ���� ������Ʈ�� ã��, ���� TextMesh������Ʈ�� ���
    }

    
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
    }

    //SceneManager needs a namespace "UnityEngine.SceneManagement"
    private void OnCollisionEnter(Collision collision) //collision�� �ڽ��ݶ��̴�������Ʈ���� 
    {
        //GetActiveScene() ���ڿ� Ÿ���� �����Ѵ�.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //�������ϱ�
    public void addScore(int s)
    {
        score += s;
        scoreOutput.text = "Score : " + score;
    }

}
