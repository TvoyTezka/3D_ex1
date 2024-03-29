using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;

    private void Update()
    {
        //������ ������ ���� ������� ����� �� �����
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //������������� ������ ���� ����� � ������
        transform.LookAt(target.position);

    }

    //��� ������������ ����� � ������� ������� ��������� ����
    private void OnTriggerEnter(Collider other)
    {
        Health box = other.GetComponent<Health>();
        box.TakeDamage(playerDamage);
    }
}
