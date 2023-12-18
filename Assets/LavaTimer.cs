using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LavaTimer : MonoBehaviour
{
    public bool isCoolDownLava;
    public float _timerEndLava;
    [SerializeField] private float _timerValueLava = 0;

    [SerializeField] public Material frLavaMaterial1;

    private FrozLava _lavaMaterial;

    void Start()
    {
        _lavaMaterial = GameObject.FindGameObjectWithTag("lava").GetComponent<FrozLava>();
    }


    void Update()
    {
        if (isCoolDownLava)
        {
            _timerValueLava += Time.deltaTime;
            if (_timerValueLava >= _timerEndLava)
            {
                isCoolDownLava = false;
                frLavaMaterial1.color = Color.white;
                ResetTimer();

            }
        }
    }

    public void ResetTimer()
    {
        _timerValueLava = 0;
    }
}
