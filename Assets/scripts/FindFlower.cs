using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindFlower : MonoBehaviour
{

    [SerializeField] public Transform target;
    public float speed = 1;
    public SleepPotTimer timerOfSleeping;

    [Header("Unity Setup")]
    public ParticleSystem sleepParticles;

    void Start()
    {

    }

    void Update()
    {
        float step = speed * Time.deltaTime;

        // Переместите нашу позицию на шаг ближе к цели.
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (timerOfSleeping.isCoolDown == false)
                speed = 1;
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

}
