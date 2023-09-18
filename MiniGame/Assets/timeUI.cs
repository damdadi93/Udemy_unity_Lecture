using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeUI : MonoBehaviour
{
    //[SerializeField] float setTime = 10.0f;
    //[SerializeField] public Text countdownText;
    public float LifitTime;
    public Text text_Timer;

    private void Start()
    {
        
    }

    private void Update()
    {
        LifitTime += Time.deltaTime;
        text_Timer.text = "Time :" + Mathf.Round( LifitTime );
    }

}
