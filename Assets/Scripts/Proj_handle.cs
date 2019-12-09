using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proj_handle : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Projectile")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.name != "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
