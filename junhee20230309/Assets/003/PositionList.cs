using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;                  //Linq �ý��� �����´�.

public class PositionList : MonoBehaviour   //���� 2�Ÿ� �̻� �ִ°��� ����
{
    public List<Vector3> positionList;
    public List<Vector3> fillter_positionList;              //r ����Ʈ �������� ���ؼ� ������
    // Start is called before the first frame update        //���� �� ������ ����Ʈ
    void Start()
    {
        LINQFunction();
    }

    public void LINQFunction()
    {
        fillter_positionList = new List<Vector3>();

        fillter_positionList = positionList
            .Where(n => Vector3.Distance(transform.position, n) > 2f)
            .OrderBy(n => Vector3.Distance(transform.position, n))
            .ToList();
    }
}

    // Update is called once per frame
