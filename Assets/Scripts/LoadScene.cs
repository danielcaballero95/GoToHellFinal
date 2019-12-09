using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    [SerializeField]
    private float loadTime = 5f;
    private float timeElapsed;
	
	// Update is called once per frame
	void Update () {

        timeElapsed += Time.deltaTime;
        if(timeElapsed > loadTime)
        {
            SceneManager.LoadScene(0);
        }
		
	}
}
