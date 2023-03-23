using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public List<int> Scores = new List<int>();
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))   //���콺 ���� ��ư
        {
            int randomNumber = Random.Range(0, 100);    //���� �ѹ� ����
            Scores.Add(randomNumber);                   //����Ʈ�� �Է�
        }

        if (Input.GetMouseButtonDown(1))
        {
            Scores.RemoveAt(3);                         //����Ʈ �ε��� 3��° ������ ����
        }
    }
}
