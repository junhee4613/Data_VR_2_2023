using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;
using UnityEngine;

public class LinqExample : MonoBehaviour
{
    List<int> numbersA = new List<int>();
    List<int> numbersB = new List<int>();
    List<int> except = new List<int>();
    List<int> intersect = new List<int>();
    List<int> union = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        numbersA.Add(1);
        numbersA.Add(2);
        numbersA.Add(5);
        numbersA.Add(8);

        numbersB.Add(1);
        numbersB.Add(3);
        numbersB.Add(5);
        numbersB.Add(7);
        numbersB.Add(9);

        //������ : numbersA���� numbersB�� �ߺ� �Ǹ� �����Ѵ�.
        //��� 2, 8
        except = numbersA.Except(numbersB).ToList();

        //������: numbersA���� numbersB�� �ߺ� �Ǹ� �����Ѵ�
        //��� 1, 5
        intersect = numbersA.Intersect(numbersB).ToList();


        //������ : numbersA���� numbersB�� �ߺ��� �ϳ��� ó���Ͽ� ��� �����Ѵ�,
        //��� 1, 2, 5, 8, 3, 7, 9
        union = numbersA.Union(numbersB).ToList();
    }

    
}
