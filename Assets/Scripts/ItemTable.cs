/*
 * Full Name: Hardik Dipakbhai Shah
 * Student ID : 101249099
 * Date Modified : October 27,2021
 * File : ItemTable.cs
 * Description : This is the script to Assignthe Ids and Open the Container when player collide with the help of OnTriggerEvent
 * Revision History : v0.1 > Added Comments to know the Code better before start anything & to include a program header
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Stores any set of items, So by clicking the right in Unity will give the option for the "System Developer" to create any kind of Itemtable
[CreateAssetMenu(fileName = "NewItemTable", menuName = "ItemSystem/ItemTable")]
public class ItemTable : ScriptableObject
{
    [SerializeField]
    private List<Item> table;  //The index of each item in the table is its ID
    public Item GetItem(int id)
    {
        return table[id];
    }
    public void AssignItemIDs() // Give each item an ID based on its location in the list
    {
        for(int i = 0; i < table.Count; i++)
        {
            try
            {
                table[i].Id = i;
            } catch(ItemModifiedException)
            {
                //it's ok
            }
        }
    }
}
