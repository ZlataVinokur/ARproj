using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class P1 : MonoBehaviour
{
    [SerializeField] public Transform target;
    public float speed = 1;
    public timerSh timerOfShield;
    
    void Start()
    {
        
    }

    void Update()
    {
        float step = speed * Time.deltaTime;

        // Переместите нашу позицию на шаг ближе к цели.
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Potion")
        {
            timerOfShield.gameObject.SetActive(true);
            timerOfShield.isCoolDawn = true;
            speed = 0;
            Destroy(other.gameObject);
        }
    }
}
