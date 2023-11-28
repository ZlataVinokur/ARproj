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
    public ParticleSystem painParticles;
    public ParticleSystem healParticles;
    [SerializeField] private float _coolDown;
    private float _timer;
    public bool CanTakeDamage { get; private set; }
    public FrozLava lavaMaterial;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "lava" && lavaMaterial.frLavaMaterial.color==Color.white)
        {
            TakeDamage(1);
        }
        else { TakeDamage(0); }
    }
    

    public void TakeDamage(int damage)
    {
        if (CanTakeDamage && damage!=0)
        {
            _health -= damage;
            Instantiate(painParticles, transform.position, Quaternion.identity);
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "HealPotion")
        {
            if (_health > 0 && _health < 15)
            {
                TakeHeal(15);
                Instantiate(healParticles, transform.position, Quaternion.identity);
                Destroy(other.gameObject);
            }
            
        }
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
