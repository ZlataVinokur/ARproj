using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;
using System;

public class SleepPotion : MonoBehaviour
{
    private FindFlower _moving;
    private SleepTimer _sleeptime;
    [Header("Unity Setup")]
    public ParticleSystem sleepParticles;
    
    /*назейр2.GetComponent<ScriptName>().SetBoolean(BOOLEAN);*/

    private void Start()
    {
       
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Animal")
        {
            Destroy();
        }
    }

    private void Destroy()
    {
        Instantiate(sleepParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
