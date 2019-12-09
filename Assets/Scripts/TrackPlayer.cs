using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrackPlayer : MonoBehaviour
{
    public Transform target;//set target from inspector instead of looking in Update
    public float speed = 3f;
    // Start is called before the first frame update
    private int timer = 0;
    void Start()
    {
        //rotate to look at the player
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcting the original rotation

    }
    void Update()
    {


        timer++;
        //move towards the player
        if (Vector3.Distance(transform.position, target.position) > 0f)
        {//move if distance from target is greater than 1
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if(timer %250 == 0)
        {
            transform.LookAt(target.position);
            transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcting the original rotation
        }
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name != "Player"){
            Destroy(this.gameObject);
        }
        else if(other.gameObject.name == "Player")
        {
            
            GameObject player = GameObject.Find("Player");
            health hScript = player.GetComponent<health>();
            hScript.hit();
            Destroy(this.gameObject);
            
        }
    }

}