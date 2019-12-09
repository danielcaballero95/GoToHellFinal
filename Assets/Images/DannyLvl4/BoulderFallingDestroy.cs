using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderFallingDestroy : MonoBehaviour
{
 
    void OnCollisionEnter2D(Collision2D coll)
    {
        
        if (coll.gameObject.tag == "CaveFallingBoulder") //Change tag
            Destroy(coll.gameObject);
    }

}
