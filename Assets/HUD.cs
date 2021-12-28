using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HUD : MonoBehaviour
{

    public Inventory Inventory;
    // Start is called before the first frame update
    void Start()
    {
        Inventory.ItemAdded += InventoryScript_Added;
    }


    private void InventoryScript_Added(object sender, InventoryEventArgs e)
    {
        Transform invetoryPanel = transform.Find("InventoryPanel");
        foreach(Transform slot in invetoryPanel)
        {
            Image image = slot.GetChild(0).GetComponent<Image>();
            if (image.enabled)
            {
                image.enabled = true;
                image.sprite = e.Item.Image;

                break;
            }
        }
 
    }

}
