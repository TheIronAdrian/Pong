using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject manager;

    public void Click()
    {
        manager.GetComponent<Manager>().isStarted = true;
        manager.GetComponent<Manager>().PausePhysics(false);
    }
}
