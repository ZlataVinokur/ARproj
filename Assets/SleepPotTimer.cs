using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepPotTimer : MonoBehaviour
{
    public bool isCoolDown;
    public float _timerEnd;
    [SerializeField] private float _timerValue = 0;

    private FindFlower animalSpeed;

    void Start()
    {
        animalSpeed = GameObject.FindGameObjectWithTag("Animal").GetComponent<FindFlower>();
    }


    void Update()
    {
        if (isCoolDown)
        {
            _timerValue += Time.deltaTime;
            if (_timerValue >= _timerEnd)
            {
                isCoolDown = false;
                animalSpeed.speed = 1;
                ResetTimer();

            }
        }
    }

    public void ResetTimer()
    {
        _timerValue = 0;
    }
}
