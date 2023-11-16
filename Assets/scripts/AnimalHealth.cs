using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class AnimalHealth : MonoBehaviour
{
    [SerializeField] public int _health;
    [Header("Unity Setup")]
    public ParticleSystem deathParticles;
    [SerializeField] private float _coolDown;
    private float _timer;
    public bool CanTakeDamage { get; private set; }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "lava")
        {
            TakeDamage(1);
        }
    }
    

    public void TakeDamage(int damage)
    {
        if (CanTakeDamage)
        {
            _health -= damage;
            CanTakeDamage = false;
        }
        
        if (_health - damage <= 0)
        {
            Destroy();
        }
    }

    public void Destroy()
    {
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void Update()
    {
        UpdateCooldown();
    }
    private void UpdateCooldown()
    {
        if (CanTakeDamage)
        {
            return;
        }
        _timer += Time.deltaTime;
        if (_timer <= _coolDown)
        {
            return;
        }
        CanTakeDamage = true;
        _timer = 0;
    }

    public void TakeHeal(int heal)
    {
        if (_health + heal <= 15)
        {
            _health += heal;
        }
        else { _health = 15; }
    }

}
