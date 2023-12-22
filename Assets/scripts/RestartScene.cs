using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    [SerializeField] private TextMeshPro _textMeshPro;

    public void OnRestartButtonClicked()
    {
        // ������������� ����� ������
        SceneManager.LoadScene(0);
    }

    public void Result(int _animalsCount)
    {
        if (_animalsCount > 0)
            _textMeshPro.text = "���� ������� ������ " + Convert.ToString(_animalsCount) + " ��������";
        else
            _textMeshPro.text = "�� ������� �� ����...";
    }    
}
