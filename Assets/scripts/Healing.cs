using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    private AnimalHealth _animal;
    [Header("Unity Setup")]
    public ParticleSystem healParticles;

    private void Start()
    {
        _animal = FindObjectOfType<AnimalHealth>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Animal")
        {
            DoHealing();
        }
    }
    public void DoHealing()
    {
        if (_animal._health > 0 && _animal._health < 20)
        {
            _animal.TakeHeal(20);
            Destroy();
        }
    }

    private void Destroy()
    {
        Instantiate(healParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
