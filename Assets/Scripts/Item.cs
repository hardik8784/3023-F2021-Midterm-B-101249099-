/*
 * Full Name: Hardik Dipakbhai Shah
 * Student ID : 101249099
 * Date Modified : October 27,2021
 * File : Item.cs
 * Description : This is the script to Assignthe Ids and Open the Container when player collide with the help of OnTriggerEvent
 * Revision History : v0.1 > Added Comments to know the Code better before start anything & to include a program header
 *                    v0.2 > Added Transfer function which shows the item has been transferred to the bag from the Box and returns boolean value if successful
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ItemModifiedException : System.Exception
{
    public ItemModifiedException(string message) : base(message)
    {
    }
}

//Attribute that allows us to right click->create
[CreateAssetMenu(fileName = "NewItem", menuName = "ItemSystem/Item")]
public class Item : ScriptableObject
{
    public new string name = "item";
    public string description = "this is an item";
    
    private int id = -1;
    public int Id
    {
        get { return id; }
        set {
            id = value;
            throw new ItemModifiedException("Oh no you dont!"); 
        }
    }

    public Sprite icon;
    public bool isConsumable = true;

    //returns whether or not the Item was successfully used
    public bool Use()
    {
        Debug.Log("Used item: " + name);
        return true;
    }

    //returns whether or not the Item was successfully Transferred
    public bool Transfer()
    {
        Debug.Log("Transferred Item: " + name);
        return true;
    }
}
