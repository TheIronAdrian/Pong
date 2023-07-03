using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject manager;

    public void Click()
    {
        manager.GetComponent<Manager>().isPaused = false;
        manager.GetComponent<Manager>().PausePhysics(false);
    }
}
