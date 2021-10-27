/*
 * Full Name: Hardik Dipakbhai Shah
 * Student ID : 101249099
 * Date Modified : October 27,2021
 * File : ItemSlot.cs
 * Description : This is the script to Assignthe Ids and Open the Container when player collide with the help of OnTriggerEvent
 * Revision History : v0.1 > Added Comments to know the Code better before start anything & to include a program header
 *                    v0.2 > Addded TransferItemInSlot function which transfers the item if it is consumable from the Box
 *                    v0.3 > Added TransferSuccessInSlot function which increase the itemCount of the Bag as it transferred from Box
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Display item in the slot, update image, make clickable when there is an item, invisible when there is not
public class ItemSlot : MonoBehaviour
{
    public Item itemInSlot = null;

    public bool bTransferSuccess = true;

    [SerializeField]
    private int itemCount = 0;
    public int ItemCount
    {
        get
        {
            return itemCount;
        }
        set
        {
            itemCount = value;
        }
    }

    [SerializeField]
    private Image icon;
    [SerializeField]
    private TMPro.TextMeshProUGUI itemCountText;


    //RefreshInfo will be called on the frame when a script is enabled just before any of the Update methods are called the first time.
    void Start()
    {

        RefreshInfo();
    }

    /// <summary>
    /// This UseItemInSlot function will check first if there is item inthe slot or not
    /// If we have any Item in slot and if it is Consumable then it will decrease the itemCount and Refresh the Info
    /// </summary>
    public void UseItemInSlot()
    {
        if(itemInSlot != null)
        {
            itemInSlot.Use();
            if (itemInSlot.isConsumable)
            {
                if (ItemCount > 0)
                {
                    itemCount--;
                    RefreshInfo();
                }
            }
        }
    }


    /// <summary>
    /// The function TransferSuccessInSlot will increase the Value of itemCount by one in the Bag
    /// After that it will Refresh the Information
    /// </summary>
    public void TransferSuccessInSlot()
    {
        //if(itemInSlot != null)
        //{
       
                itemCount++;
                Debug.Log("Item Added To the Bag: " + name + " & New ItemCount is: " + itemCount + "!");
                RefreshInfo();
            
       
        //{
        //    itemCount++;
        //    Debug.Log("Item Added To the Bag: " + name + " & New ItemCount is: " + itemCount + "!");
        //    RefreshInfo();
        //}
        //}
    }

   
    /// <summary>
    /// The function TransferItemInSlot will first check there is ItemInSlot or not
    /// Then it will check if it is Consumable or not, if so it will decrease the itemCount from the Box and Refresh the Information
    /// </summary>
    public void TransferItemInSlot()
    {
        if (itemInSlot != null)
        {
            if (itemInSlot.isConsumable)
            {
                if (ItemCount >= 1)
                {
                    itemInSlot.Transfer();
                    itemCount--;
                    RefreshInfo();
                    //Unique();
                    //TransferSuccessInSlot();
                    //bTransferSuccess = true;
                }
            }
        }
    }


    /// <summary>
    /// The function RefreshInfo checks the item is present or not 
    /// If so, It changes the ItemCount to it's value and set the sprite to it
    /// </summary>
    public void RefreshInfo()
    {
        //if(ItemCount < 1)
        //{
        //    itemInSlot = null;
        //}

        if (itemInSlot != null) // If an item is present
        {
            //update image and text
            itemCountText.text = ItemCount.ToString();
            icon.sprite = itemInSlot.icon;
            icon.gameObject.SetActive(true);
        }
         else
        {
            // No item
            itemCountText.text = "0";
            //Debug.Log("ItemCount is 0");
            //icon.gameObject.SetActive(false);
        }
    }
}
