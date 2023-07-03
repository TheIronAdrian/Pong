using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGoBrrr : MonoBehaviour
{
    public int time;

    private void FixedUpdate()
    {
        if(time < 0)
        {
            time = 100;
            GetComponent<Rigidbody2D>().velocity=(GetComponent<Rigidbody2D>().velocity * 1.1f) ;
        }
        time--;
    }
}
