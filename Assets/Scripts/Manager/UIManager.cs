using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{


    [SerializeField] private SlotItem[] slotItems;

    public void Init()
    {
        Debug.Log("UIManager Init");
    }

    public void InventoryUIUpdate(List<int> items)
    {
        
    }
}
