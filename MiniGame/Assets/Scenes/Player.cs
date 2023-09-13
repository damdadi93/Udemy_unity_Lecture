using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //physical power add
    //"float" is �Ǽ� �ڷ���(data tyPe)
    
    public float jumpPower = 5f;
    public float jumpBoost = 2.5f;
    public float lowWarn = -4;
    public float speed = 1;
    public float step = 0.5f;
    public float scale = 1;
    public float targetScale = 2f;

    

    public float maxHp = 100;


    public Material[] MColor;
    
   
    public Rigidbody rb;
    TextMesh scoreOutput;
    int score = 0;
    [SerializeField]
    float currentHp = 0;


    void Start()
    {
        scoreOutput = GameObject.Find(name: "Score").GetComponent<TextMesh>();
            //�̸����� ���� ������Ʈ�� ã��, ���� TextMesh������Ʈ�� ���
    
        rb = GetComponent<Rigidbody>();

        currentHp = maxHp;
        MColor[0].color = Color.green;
    }

    
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            if(transform.position.y < lowWarn)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower * jumpBoost, 0);
            }
            else
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
            }
          
        }

        //transform.Translate(speed * Time.deltaTime,0,0);
        // transform.position+= new Vector3(step * Time.deltaTime, 0, 0);

        transform.localScale += new Vector3(0, scale * Time.deltaTime, 0);



        transform.localScale -= new Vector3(0, scale * Time.deltaTime, 0);
    
        


        //if (transform.position.y <= 0f)
        //{
        //    //rb.AddForce()
        //       // Impulse(transform.up * jumpPower * Time.deltaTime);
        //}
        //jumpPower = 5f;




    }

    //SceneManager needs a namespace "UnityEngine.SceneManagement"
    private void OnCollisionEnter(Collision collision) //collision�� �ڽ��ݶ��̴�������Ʈ���� 
    {
        currentHp -= 35;
        

        if (currentHp <= 0)
        {
            //GetActiveScene() ���ڿ� Ÿ���� �����Ѵ�.
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
       
    }

    //�������ϱ�
    public void addScore(int s)
    {
        score += s;
        scoreOutput.text = "Score : " + score;
    }

}
