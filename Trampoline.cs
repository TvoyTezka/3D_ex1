using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //������� ���� ������ 10
        other.GetComponent<Jump>().jumpStrength = 10;
    }
    private void OnTriggerExit(Collider other)
    {
        //������� ���� ������ ������� 2
        other.GetComponent<Jump>().jumpStrength = 2;
    }
}
