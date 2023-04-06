using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
//3��° ��ųʸ�
public class InventoryExample : MonoBehaviour
{
    public InventoryManager inventoryManager;                   //�Ŵ����� �޾ƿ´�.
    // Start is called before the first frame update
    void Start()
    {
        Item apple = new Item { itemName = "Apple", itemID = 1, itemCount = 3 };            //������ ����
        Item banana = new Item { itemName = "Banana", itemID = 2, itemCount = 5 };
        Item orange = new Item { itemName = "Orange", itemID = 3, itemCount = 2 };

        inventoryManager.AddItem(apple);                    //������ �������� �Է�
        inventoryManager.AddItem(banana);
        inventoryManager.AddItem(orange);

        inventoryManager.PrintInventory();                  //����Ʈ

        inventoryManager.RemoveItem(2, 3);

        inventoryManager.PrintInventory();

        var sortedByValue = inventoryManager.inventory.OrderBy(pair =>pair.Value.itemCount).ToDictionary
            (pair => pair.Value.itemName, pair => pair.Value.itemCount);                //������ ���� ������� ����

        foreach(KeyValuePair<string, int> entry in sortedByValue)
        {
            Debug.Log("Key : " + entry.Key + "Value : " + entry.Value);                     //������ �Ѵ�.
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
