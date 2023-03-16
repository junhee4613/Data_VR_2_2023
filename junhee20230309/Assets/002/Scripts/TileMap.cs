using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour
{
    public GameObject TileQuad;
    public float TileSize = 1.0f;
    public enum TerrainEnum : int  //TerrainEnum ����
    {
        GRASS,
        SAND,
        WATER,
        WALL
    }

    public TerrainEnum[,] map =   //�� ������ ����
    {
        { TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND },
        { TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.WALL },
        { TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND },
        { TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND },
        { TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND },
        { TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND },
        { TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND ,TerrainEnum.SAND }

    };
    // Start is called before the first frame update
    void Start()
    {
        for(int row = 0; row < map.GetLength(0); row++)
        {
            for(int column = 0; column < map.GetLength(1); column++)
            {
                GameObject Temp = (GameObject)Instantiate(TileQuad);
                Temp.transform.position = new Vector3(column * TileSize ,  -row * TileSize, 0);
                
                //TileColor �����ؼ� Ÿ�� �ʿ� ���ǵ� ������ ��ġ�� �Ѵ�.
                Temp.GetComponent<TileColor>().TileColorType = (TileColor.TerrainEnum)map[row, column];
            }
        }
    }

}
