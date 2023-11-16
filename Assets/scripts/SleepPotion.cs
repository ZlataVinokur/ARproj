using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class SleepPotion : MonoBehaviour
{
    private FindFlower _moving;
    private SleepTimer _sleeptime;
    [Header("Unity Setup")]
    public ParticleSystem sleepParticles;
    

    private void Start()
    {
        _moving = FindObjectOfType<FindFlower>();
        _sleeptime = FindObjectOfType<SleepTimer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Animal")
        {
            DoSleeping();
            _sleeptime._sleepPotActivated = true;
        }
    }

    public void DoSleeping()
    {
        while (_sleeptime._sleepPotActivated == true)
        {
            _moving.speed = 0;
        }
        Destroy();
    }

    private void Destroy()
    {
        Instantiate(sleepParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
