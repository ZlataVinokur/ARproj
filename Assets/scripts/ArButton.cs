using UnityEngine;
using System;
using TMPro;
using Microsoft.MixedReality.Toolkit.UI;

public class ArButton : MonoBehaviour
{

    public event Action OnButtonClicked;

    [SerializeField] private TextMeshPro _title;
    [SerializeField] private Interactable _interactable;

    private GameObject _prefab;

    public void Initialize(Item config)
    {
        _title.text = config.Title +'\n'+ config.Price;
        _prefab = config.Prefab;

        _interactable.OnClick.AddListener(ProcessClick);
    }

    private void ProcessClick()
    {
        OnButtonClicked?.Invoke();
        SpawnItem();
    }

    public void SpawnItem()
    {
        Instantiate(_prefab, transform.position - new Vector3(0.3f, 0.3f), Quaternion.identity);
    }
}
