using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerSh : MonoBehaviour
{
    public bool isCoolDawn;
    public float _timerEnd;
    [SerializeField] private float _timerValue = 0;

    private P1 p1;
    private P1 p1Speed;

    void Start()
    {
        p1 = GameObject.FindGameObjectWithTag("Animal").GetComponent<P1>();
        p1Speed = GameObject.FindGameObjectWithTag("Animal").GetComponent<P1>();
       
    }

   
    void Update()
    {
        if(isCoolDawn)
        {
            _timerValue+=Time.deltaTime;
            if (_timerValue >= _timerEnd)
            {
                isCoolDawn=false;
                p1Speed.speed = 1;
                ResetTimer();

            }
        }
    }

    public void ResetTimer()
    {
        _timerValue=0;
    }

}
