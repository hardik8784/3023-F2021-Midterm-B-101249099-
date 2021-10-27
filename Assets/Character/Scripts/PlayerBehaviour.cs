/*
 * Full Name: Hardik Dipakbhai Shah
 * Student ID : 101249099
 * Date Modified : October 26,2021
 * File : PlayerBehaviour.cs
 * Description : This is the script to Assignthe Ids and Open the Container when player collide with the help of OnTriggerEvent
 * Revision History : v0.1 > Added Comments to know the Code better before start anything & to include a program header
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");                              //This will help player to move left and right direction by pressing A & D keys
        float inputY = Input.GetAxisRaw("Vertical");                                //This will help player to move up and down direction by pressing the W & S keys
        transform.position += new Vector3(inputX * moveSpeed * Time.deltaTime, inputY * moveSpeed * Time.deltaTime, 0);                 //This will change the position of the player 
    }
}
