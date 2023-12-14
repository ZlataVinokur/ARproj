using Microsoft.MixedReality.Toolkit.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public event Action OnButtonClicked;
    public FindFlower scriptFindFl;
    
    void Start()
    {
        scriptFindFl = GetComponent<FindFlower>();
    }

    private void ProcessClick()
    {
        OnButtonClicked?.Invoke();
        scriptFindFl.gameObject.SetActive(true);
    }
    
}
