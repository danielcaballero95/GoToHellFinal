using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    public bool hasKey = false;
    public UnityEngine.Events.UnityEvent PlatformsToMove;
    private AudioSource audio;
    private int audioPlayCount;
    
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audioPlayCount = 0;
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {

        hasKey = true;
        Debug.Log(hasKey);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        PlatformsToMove.Invoke();
        if (audioPlayCount <= 0)
        {

            audioPlayCount++;
            audio.Play();
        }
        //audio.mute = true;
    }

}
