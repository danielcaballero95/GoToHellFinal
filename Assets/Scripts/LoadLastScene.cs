using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLastScene : MonoBehaviour
{
    [SerializeField]
    private float loadTime = 3f;
    private float timeElapsed;


    // Update is called once per frame
    void Update()
    {

        timeElapsed += Time.deltaTime;
        if(timeElapsed > loadTime)
        {
            SceneManager.LoadScene(2);
        }
        
    }
}
