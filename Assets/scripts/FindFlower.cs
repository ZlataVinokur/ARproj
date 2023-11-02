using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindFlower : MonoBehaviour
{

    [SerializeField] public Transform target;
    [SerializeField] public float speed;

    void Update()
    {
        // ������ ���� ����� �������� * ����� �����.
        float step = speed * Time.deltaTime;

        // ����������� ���� ������� �� ��� ����� � ����.
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

}
