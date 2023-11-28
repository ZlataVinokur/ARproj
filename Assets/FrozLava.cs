using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrozLava : MonoBehaviour
{
    public LavaTimer timerOfFrozLava;
    [SerializeField] public Material frLavaMaterial;


    [Header("Unity Setup")]
    public ParticleSystem frozeParticles;

    void Start()
    {
        frLavaMaterial.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FrozPotion")
        {
            timerOfFrozLava.gameObject.SetActive(true);
            timerOfFrozLava.isCoolDownLava = true;
            frLavaMaterial.color = Color.blue;
            Instantiate(frozeParticles, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
    }

}
