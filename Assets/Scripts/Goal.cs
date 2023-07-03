using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    public int Player;
    public GameObject manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (Player)
        {
            case 1:
                manager.GetComponent<Manager>().scorePlayer2++;
                manager.GetComponent<Manager>().restart = 2;
                break;
            case 2:
                manager.GetComponent<Manager>().scorePlayer1++;
                manager.GetComponent<Manager>().restart = 1;
                break;
        }
    }
   
}
