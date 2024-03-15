using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public string sceneName;
    public TextMeshProUGUI timerText;

    //������� ����������� �������� ������ 0.01 �������
    void Update()
    {
        seconds -= Time.deltaTime;
        print(seconds);

        if (seconds <= 0)
        {
            if (minutes > 0)
            {
                seconds += 59;
                minutes --;
            }
            else
            {
                //���� ������ �����������, ��������� �������
                EditorSceneManager.LoadScene(sceneName);
            }
        }
        //��������� �������� ������ �� ����� � ������� �� �����
        int roundSeconds = Mathf.RoundToInt(seconds);
        timerText.text = minutes + ":" + roundSeconds;

    }
}
