using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Angel_Attack : MonoBehaviour
{
    
    public GameObject projectile;
    public Transform player;
    public Transform this_angel;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter % 100 == 0 && (Vector2.Distance(player.position, this_angel.position)) < 25)
        {
             Instantiate(projectile, this_angel.position, Quaternion.identity);
            
        }
    }
}
