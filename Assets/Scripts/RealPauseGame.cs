using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealPauseGame : MonoBehaviour
{
    public GameObject manager;

    public void Click()
    {
        manager.GetComponent<Manager>().isPaused = true;
        manager.GetComponent<Manager>().PausePhysics(true);
    }
}
