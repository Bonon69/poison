using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Food Object", menuName = "Inventory System/items/Food")]
public class FoodObject : Itemobject
{
    public void Awake()
    {
        type = ItemType.Food;
    }
}
