using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepTimer : MonoBehaviour
{
    private FindFlower _moving;
    [Header("Unity Setup")]
    public float _timerEnd;
    [SerializeField] private float _timerValue=0;
    public bool _sleepPotActivated;

    private void Start()
    {
        _moving = FindObjectOfType<FindFlower>();
        SetBoolean(false);
    }
    

    void Update()
    {
        if (_sleepPotActivated == true)
        {
            _timerValue += Time.deltaTime;
            if (_timerValue >= _timerEnd)
            {
                SetBoolean(false);
                _timerValue = 0;
            }
        }

    }

    public void SetBoolean (bool BOOLEAN)
    {
        _sleepPotActivated = BOOLEAN;
    }
}
