using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackReverse : MonoBehaviour
{

    Stack<int> stackNumber = new Stack<int>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            stackNumber.Push(i);                                        //Push ���ÿ� �о�ִ� �Լ�
        }                                                               // => 0/1/2/3/4/5/6/7/8/9

        string temp = "";
        while(stackNumber.Count > 0)
        {
            temp += stackNumber.Pop().ToString() + " / ";               //Pop ���ÿ� �� ���� �ִ� ���� ������.
        }
                                                
        Debug.Log(temp);                                               // => 9/8/7/6/5/4/3/2/1/0
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
