using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileColor : MonoBehaviour   //Ÿ�� ������Ʈ�� ���� Ŭ���� (prefabs)
{

    Renderer rend;        //�������� �����´�.


    public enum TerrainEnum : int      // ���ڷ� Ÿ���� �����ϱ� ���ؼ� (int) ���� Bute�ε� �Ͻô� �е�����
    {
        GRASS,
        SAND,
        WATER,
        WALL
    }


    public TerrainEnum TileColorType; 
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        if (TileColorType == TerrainEnum.GRASS)
            rend.material.SetColor("_Color", Color.green);
        if (TileColorType == TerrainEnum.SAND)
            rend.material.SetColor("_Color", Color.yellow);
        if (TileColorType == TerrainEnum.WATER)
            rend.material.SetColor("_Color", Color.blue);
        if (TileColorType == TerrainEnum.WALL)
            rend.material.SetColor("_Color", Color.grey);

    }

}
