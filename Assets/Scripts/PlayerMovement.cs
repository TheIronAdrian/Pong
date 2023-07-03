using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int WhatPlayerControll;
    public int Up, Down;
    public GameObject Manager;

    // Update is called once per frame
    void Update()
    {
        switch (WhatPlayerControll)
        {
            case 1:
                if (Input.GetKey(KeyCode.W))
                {
                    Up = 1;
                }
                else 
                { 
                    Up = 0;
                }
                

                if (Input.GetKey(KeyCode.S))
                {
                    Down = 1;
                }
                else
                {
                    Down = 0;
                }
                
                break;
            case 2:
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    Up = 1;
                }
                else
                {
                    Up = 0;
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    Down = 1;
                }
                else
                {
                    Down = 0;
                }
                break;
        }
    }

    void FixedUpdate()
    {
        if (Up + Down == 1)
        {
            if (Up == 1)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 30f, 0));
            }
            else
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -30f ,0));
            }
        }        
    }
}
