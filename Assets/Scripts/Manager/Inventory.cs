using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Inventory : MonoBehaviour
{
    public List<int> inventory;

    public float total_weight;

    public void Init()
    {
        inventory = new List<int>();
    }

    public void ItemSorting(int index)
    {
        switch(index)
        {
            case 0: PriceSorting();
                break;
            case 1: WeightSorting();
                break;
            case 2: GradeSorting();
                break;
        }
    }

    public void AddItem(int data)
    {
        inventory.Add(data);
    }

    public void RemoveItem()
    {

    }

    public void ItemUpdate()
    {
        GameManager.Instance.UIManager.InventoryUIUpdate(inventory);
    }

    private void PriceSorting()
    {

    }

    private void WeightSorting()
    {

    }

    private void GradeSorting()
    {

    }
}
