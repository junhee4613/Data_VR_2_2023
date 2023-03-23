using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;                  //Linq 시스템 가져온다.

public class PositionList : MonoBehaviour   //나와 2거리 이상에 있는것을 정렬
{
    public List<Vector3> positionList;
    public List<Vector3> fillter_positionList;              //r 리스트 가져오기 위해서 선ㅇ언
    // Start is called before the first frame update        //필터 후 정렬할 리스트
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
