using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class Item                                               //Item Class ����
{
    public string itemName;
    public int itemID;
    public int itemCount;
}
public class InventoryManager : MonoBehaviour
{
    public Dictionary<int, Item> inventory = new Dictionary<int, Item>();                           //Dictionary ����(int, Item)

    public void AddItem(Item newItem)                                                               //������ �߰� �Լ�
    {
        if(inventory.ContainsKey(newItem.itemID))                                                  //ContainsKey �ش� ID���� �ֳ� �˻�
        {
            inventory[newItem.itemID].itemCount += newItem.itemCount;                               //���� ���� ��� itemCount�� �÷��ش�.
        }
        else
        {
            inventory.Add(newItem.itemID, newItem);                                                 //���� ������� ���� �Է�
        }
    }

    public void RemoveItem(int itemID, int count = 1)                                               //������ ���� �Լ�
    {
        if (inventory.ContainsKey(itemID))                                                          //ContainsKey �ش� ID���� �ֳ� �˻�
        {
            inventory[itemID].itemCount -= count;                                                   //count �� ����

            if(inventory[itemID].itemCount <= 0)                                                    //0 ������ ��� ����
            {
                inventory.Remove(itemID);
            }
        }
    }

    public Item GetItem(int itemID)
    {
        if (inventory.ContainsKey(itemID))                                                          //ContainsKey �ش� ID���� �ֳ� �˻�
        {
            return inventory[itemID];
        }
        else
        {
            return null;
        }
    }

    public void PrintInventory()
    {
        foreach(KeyValuePair<int, Item> item in inventory)                                      //��ü������ ���鼭 ����Ʈ
        {
            Debug.Log("Item: " + item.Value.itemName + ", Count" + item.Value.itemCount);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
