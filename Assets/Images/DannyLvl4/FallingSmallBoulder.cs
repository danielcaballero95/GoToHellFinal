using UnityEngine;
public class FallingSmallBoulder : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    private Vector3 spawnLoc;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    { 
        // Instantiate at position (0, 0, 0) and zero rotation.
        Instantiate(myPrefab, new Vector3(49.1f, 0.1f, -2.385369f), Quaternion.identity);
        InvokeRepeating("spawn", 1,Random.Range(3f, 6f));
    }
    
 

    void spawn()
    {
    //GameObject.Instantiate(my);
      spawnLoc=transform.localPosition;
        Debug.Log(spawnLoc);

        Instantiate(myPrefab, spawnLoc, Quaternion.identity);
    }

}