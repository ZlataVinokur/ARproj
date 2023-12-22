using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VisibleCount : MonoBehaviour
{
    [SerializeField] private PlayerMoney _playerMoney;
    [SerializeField] private MainTimerScript _timeLeft;
    private int _timeInt;
    [SerializeField] private TextMeshPro _textMeshPro;

    private void Update()
    {
        _timeInt = Convert.ToInt32(_timeLeft._MainTimerEnd-_timeLeft._mainTimerValue);
        _textMeshPro.text = "очки: " + Convert.ToString(_playerMoney._moneyAmount) + '\n' + "время: " + Convert.ToString(_timeInt);
    }
}
