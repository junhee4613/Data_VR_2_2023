using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTableExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Hashtable hashtable = new Hashtable();                  //�ؽ� ���̺� ����

        //Ű-�� �� �߰�
        hashtable.Add("Apple", 3);
        hashtable.Add("Banana", 5);
        hashtable.Add("Orange", 2);
                                                            //����� ����: ������Ʈ�� ��ũ��Ʈ �߰�- ����Ƽ �÷��� - ���� ���� ����Ƽ ���� - ���翡 �ش� ���� �巡�� 
        //�� �˻�
        int appleCount = (int)hashtable["Apple"];
        Debug.Log("Apple count : " + appleCount);

        //Ű-�� �� ����
        hashtable["Apple"] = 4;
        //Ű-�� ����
        hashtable.Remove("Banana");

        //�� �˻�
        int appleCount2 = (int)hashtable["Apple"];
        Debug.Log("Apple count : " + appleCount2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
