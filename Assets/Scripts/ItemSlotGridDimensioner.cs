/*
 * Full Name: Hardik Dipakbhai Shah
 * Student ID : 101249099
 * Date Modified : October 27,2021
 * File : ItemSlotGridDimensioner.cs
 * Description : This is the script to Assignthe Ids and Open the Container when player collide with the help of OnTriggerEvent
 * Revision History : v0.1 > Added Comments to know the Code better before start anything & to include a program header
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Instantiates prefabs to fill a grid, So it will automatically assign the layout, we just have to fill in the 2*2 Vector2
[RequireComponent(typeof(GridLayout))]
public class ItemSlotGridDimensioner : MonoBehaviour
{
    [SerializeField]
    GameObject itemSlotPrefab;

    [SerializeField]
    Vector2Int GridDimensions = new Vector2Int(6, 6);

    void Start()
    {
        int numCells = GridDimensions.x * GridDimensions.y;

        while (transform.childCount < numCells)
        {
            GameObject newObject = Instantiate(itemSlotPrefab, this.transform);
        }
    }
}
