using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class poison_one : MonoBehaviour, IInventoryItem
{
    public string Name
    {
        get
        {
            return "1";
        }
    }
    public Sprite _Image = null;

    public Sprite Image
    {
        get
        {
            return Image;
        }
    }
    public void OnPickup()
    {
        gameObject.SetActive(false);
    }
}
