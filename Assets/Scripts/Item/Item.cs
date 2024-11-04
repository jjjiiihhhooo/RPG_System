using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item Data", menuName = "Scriptable Object/Item Data", order = int.MaxValue)]
public class Item : ScriptableObject
{
    public Type type;

    public int grade;

    public float price;
    public float weight;

    public float plusHP;
    public float plusMP;
    public float damage;

    public Sprite slotImage;

}
