/*
 * Full Name: Hardik Dipakbhai Shah
 * Student ID : 101249099
 * Date Modified : October 27,2021
 * File : Inventory.cs
 * Description : This is the script to Assignthe Ids and Open the Container when player collide with the help of OnTriggerEvent
 * Revision History : v0.1 > Added Comments to know the Code better before start anything & to include a program header
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    GameObject containerCanvas;

    [SerializeField]
    ItemTable itemTable;

    private void Start()
    {
        itemTable.AssignItemIDs();
    }

    public void OpenContainer()
    {
        containerCanvas.SetActive(true);
    }

    public void CloseContainer()
    {
        containerCanvas.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)                 //When Player collides with this it opens up the Container
    {
       // if (collision.gameObject.tag == "Container")
        {
            OpenContainer();
        }
    }
    void OnTriggerExit2D(Collider2D collision)                  //When it is not colliding with this it closes off the Container
    {
      //  if (collision.gameObject.tag == "Container")
        {
            CloseContainer();
        }
    }
}
