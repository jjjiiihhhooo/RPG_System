using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type
{
    Weapon, Armor, Potion, Quest, Grade
}

//00     000
//index  count




public class ItemManager : MonoBehaviour
{
    public Item[] ItemDatas;

    public void Init()
    {
        Debug.Log("ItemManager Init");
    }
}

