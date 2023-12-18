using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindFlower : MonoBehaviour
{

    [SerializeField] public Transform target;
    public float speed = 0.3f;
    public SleepPotTimer timerOfSleeping;

    [Header("Unity Setup")]
    public ParticleSystem sleepParticles;

    public bool isOnGround;

    void Start()
    {
        isOnGround = true;
    }

    void Update()
    {
        float step = speed * Time.deltaTime;

        // Переместите нашу позицию на шаг ближе к цели.
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (timerOfSleeping.isCoolDown == false && isOnGround==true)
                speed = 0.3f;
        if (isOnGround == false)
        {
            speed = 0;
            Debug.Log("bbbb");
        }
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Potion")
        {
            timerOfSleeping.gameObject.SetActive(true);
            timerOfSleeping.isCoolDown = true;
            speed = 0;
            Instantiate(sleepParticles, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Air")
        {
            isOnGround = false;
        }
        else isOnGround = true;
    }

    /*private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Ground" || other.tag == "lava")
        {
            isOnGround = true;
            
        }

        else
        {
            isOnGround = false;
            
        }
        Debug.Log("aaa");
    }*/

}
