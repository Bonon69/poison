using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display : MonoBehaviour
{
    public InventoryObject inventory;
    public int X_Start;
    public int Y_Start;
    public int X_Space_between;
    public int NUMBER_OF_COLUMN;
    public int Y_Space_between;
    Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();

    private void Start()
    {
        CreateDisplay();
    }
    private void Update()
    {
        //UpdateDisplay();
    }
    public void CreateDisplay()
    {
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i); 
        }
    }
    public void UpdateDisplay()
    {
        for(int i = 0; i< inventory.Container.Count; i++)
        {
            if (itemsDisplayed.ContainsKey(inventory.Container[i]))
            {
                
            }
        }
    }

    public Vector3 GetPosition(int i)
    {
        return new Vector3(X_Start + (X_Space_between * (i % NUMBER_OF_COLUMN)), Y_Start + (-Y_Space_between * (i / NUMBER_OF_COLUMN)), 0f);
    }
    

}
