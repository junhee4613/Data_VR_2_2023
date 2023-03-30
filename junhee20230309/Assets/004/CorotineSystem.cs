using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorotineSystem : MonoBehaviour
{
    private Queue coroutineQueue = new Queue();                     //�ڷ�ƾ �����ϴ� ť �ڷᱸ��

    public void AddCorutineQueue(IEnumerator coroutine)             //������ �ڷ�ƾ Add �Լ�
    {
        coroutineQueue.Enqueue(coroutine);                          //�Լ��� ���ؼ� �ڷ�ƾ�� �޴´�.
    }
    // Start is called before the first frame update
    void Start()
    {
        AddCorutineQueue(Logging(10));
        AddCorutineQueue(Logging(100));
        AddCorutineQueue(Logging(1000));
        if(coroutineQueue.Count > 0)                                //���������� �ڷ�ƾ�� ť�� �׿������� �ϳ� ������ ����
        {
            StartCoroutine((IEnumerator)coroutineQueue.Dequeue());
        }

    }

    IEnumerator Logging(int number)                                 //�α�
    {
        for(int i = number; i < number + 10; i++)
        {
            Debug.Log(i.ToString() + "<---");
            yield return new WaitForSeconds(0.1f);
        }

        if(coroutineQueue.Count > 0)
        {
            StartCoroutine((IEnumerator)coroutineQueue.Dequeue());
        }
    }
 
}
