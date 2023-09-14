using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    public bool isHit = false;

    public float time = 2;

    public float damage = 35;
    public float maxHp = 100;
    public Material MColor;
    public MeshRenderer Mesh;
    public Rigidbody rb;
    public BoxCollider BC;
    
   
    

    Renderer playerColor;

    TextMesh scoreOutput;
    int score = 0;
    [SerializeField]
    float currentHp = 0;
    

    void Start()
    {
        scoreOutput = GameObject.Find(name: "Score").GetComponent<TextMesh>();
            //�̸����� ���� ������Ʈ�� ã��, ���� TextMesh������Ʈ�� ���
    
        rb = GetComponent<Rigidbody>();
        BC = GetComponent<BoxCollider>();
        playerColor = gameObject.GetComponent<Renderer>(); //��������Ʈ�� �ѹ���...�ؾ��ϴµ�
        //MColor = playerColor.material;
        currentHp = maxHp;
        //Mesh.materials.Length = 3;
        //MColor[0].color = Color.green;
        //isHit = (BC.isTrigger = true);
        
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

        ////transform.localScale += new Vector3(0, scale * Time.deltaTime, 0);



        //transform.localScale -= new Vector3(0, scale * Time.deltaTime, 0);




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

        //�浹�Ŀ� 1�ʵ��� ����....
        //�浹�Ҷ� ���� �ٲ�� ���ǹ�

        
        StartCoroutine(beatColor());
        currentHp -= damage;
        if (currentHp <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
           

        //if (playerColor.material.color == Color.green && currentHp ==65)
        //{

        //   
        //}
        //else if(playerColor.material.color == Color.yellow && currentHp ==30)
        //{

        //    playerColor.material.color = Color.red;
        //}
        //else if (playerColor.material.color == Color.red && currentHp <= 0)
        //{
        //    //GetActiveScene() ���ڿ� Ÿ���� �����Ѵ�.
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //}
        //else if (playerColor.material.color == Color.red && currentHp <= 0)
        //{
        //    //GetActiveScene() ���ڿ� Ÿ���� �����Ѵ�.
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //}


    }
    




    //�������ϱ�
    public void addScore(int s)
    {
        score += s;
        scoreOutput.text = "Score : " + score;
    }
    
    //�������� Trigger
    IEnumerator beatColor()
    {        
        for(int i =0; i<2;  i++)
        {   
            rb.isKinematic = true;
            
            yield return new WaitForSeconds(0.1f);
            playerColor.material.color = Color.white;
            yield return new WaitForSeconds(0.1f);
            playerColor.material.color = Color.black;
            yield return new WaitForSeconds(0.1f);

        }
        rb.isKinematic = false;

        if (currentHp <= 100 && currentHp >= 65)
        {
            playerColor.material.color = Color.yellow;
        }
        else if (currentHp <= 64 && currentHp > 0)
        {
            playerColor.material.color = Color.red;
        }
       

        yield return null;
           
    }
}
