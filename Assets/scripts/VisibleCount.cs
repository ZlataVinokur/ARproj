using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VisibleCount : MonoBehaviour
{
    [SerializeField] private PlayerMoney _playerMoney;
    [SerializeField] private TextMeshPro _textMeshPro;

    private void Update()
    {
        _textMeshPro.text = "очки " + Convert.ToString(_playerMoney._moneyAmount);
    }
}
