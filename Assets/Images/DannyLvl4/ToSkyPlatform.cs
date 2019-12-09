using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToSkyPlatform : MonoBehaviour
{
    
    public UnityEngine.Events.UnityEvent PlatformsToMove;

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("hi");
        OnTriggerEnter2D();
    }



    private void OnTriggerEnter2D()
    {
        //Debug.Log(other);
        PlatformsToMove.Invoke();

    }
}