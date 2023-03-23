using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public List<int> Scores = new List<int>();
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))   //마우스 왼쪽 버튼
        {
            int randomNumber = Random.Range(0, 100);    //랜덤 넘버 생성
            Scores.Add(randomNumber);                   //리스트에 입력
        }

        if (Input.GetMouseButtonDown(1))
        {
            Scores.RemoveAt(3);                         //리스트 인덱스 3번째 내용을 삭제
        }
    }
}
