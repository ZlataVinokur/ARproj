using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepTimer : MonoBehaviour
{
    private FindFlower _moving;
    [Header("Unity Setup")]
    public ParticleSystem sleepParticles;
    [SerializeField] public float _timerEnd;
    [SerializeField] private float _timerValue=0;
    public bool _sleepPotActivated = false;

    private void Start()
    {
        _moving = FindObjectOfType<FindFlower>();
    }
    

    void Update()
    {
        if (_sleepPotActivated == true)
        {
            _timerValue += Time.deltaTime;
            if (_timerValue >= _timerEnd)
            {
                _sleepPotActivated = false;
                _timerValue = 0;
            }
        }

    }
}
