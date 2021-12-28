using UnityEngine;
[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Inventory System/items/Equipment")]
public class Equipment : Itemobject
{
    public void Awake()
    {
        type = ItemType.Equipment;
    }
}
