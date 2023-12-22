using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MainTimerScript : MonoBehaviour
{
    public float _MainTimerEnd;
    [SerializeField] public float _mainTimerValue = 0;
    [SerializeField] private GameObject _textMeshPro;
    [SerializeField] private GameObject _storeMenu;
    [SerializeField] private GameObject _gameOverMenu;
    [SerializeField] private GameObject _flower;
    [SerializeField] private RestartScene _textMeshProResult;

    void Start()
    {
        _textMeshPro.SetActive(false);
    }


    void Update()
    {
        _mainTimerValue += Time.deltaTime;
        int _animalsCount = GameObject.FindGameObjectsWithTag("Animal").Length;
        if (_mainTimerValue >= _MainTimerEnd || _animalsCount==0)
        {
            _textMeshPro.SetActive(true);
            _storeMenu.SetActive(false);
            _gameOverMenu.SetActive(true);
            _textMeshProResult.Result(_animalsCount);
            _flower.SetActive(false);
            ResetTimer();
            this.gameObject.SetActive(false);
        }

    }

    public void ResetTimer()
    {
        _mainTimerValue = 0;
    }
}
