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
        // Перезагружаем сцену заново
        SceneManager.LoadScene(0);
    }

    public void Result(int _animalsCount)
    {
        if (_animalsCount > 0)
            _textMeshPro.text = "тебе удалось спасти " + Convert.ToString(_animalsCount) + " пингвина";
        else
            _textMeshPro.text = "ты потерял их всех...";
    }    
}
