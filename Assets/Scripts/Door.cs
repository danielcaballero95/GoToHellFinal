using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

    GameObject obj;
    private AudioSource audio;
    private int audioPlayCount;
    
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audioPlayCount = 0;


    }

        
        private void OnTriggerStay2D(Collider2D other)
    {
        audio = GetComponent<AudioSource>();
        obj = GameObject.FindGameObjectWithTag("Key");
        bool openDoor = obj.GetComponent<Key>().hasKey;
        Debug.Log(openDoor);
      
        if (audioPlayCount <= 0)
        {

            audioPlayCount++;
            audio.Play();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && openDoor == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       
    }
}
