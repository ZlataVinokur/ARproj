using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindFlower : MonoBehaviour
{

    [SerializeField] public Transform target;
    [SerializeField] public float speed;

    void Update()
    {
        // –азмер шага равен скорость * врем€ кадра.
        float step = speed * Time.deltaTime;

        // ѕереместите нашу позицию на шаг ближе к цели.
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

}
