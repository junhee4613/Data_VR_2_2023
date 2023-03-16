using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] months = new string[12];   //12���� ���ڿ� �迭�� �����Ѵ�.

        for(int month = 1; month <= 12; month++)
        {
            DateTime firstDay = new DateTime(DateTime.Now.Year, month, 1);
            string name = firstDay.ToString("MMM", CultureInfo.CreateSpecificCulture("Ko-KR"));
            months[month - 1] = name;  //for���� 1���� �����ؼ� 1�� ���� �����ϰ� ����
        }

        foreach(string month in months)
        {
            Debug.Log(month);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
