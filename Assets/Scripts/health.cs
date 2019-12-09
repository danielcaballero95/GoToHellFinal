using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public int maxHealth;
    public int player_health;
    private float healthBarlength;
    // Start is called before the first frame update
    void Start()
    {
        healthBarlength = Screen.width / 2;
    }
    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, healthBarlength, 20), player_health + "/" + maxHealth);
    }
    // Update is called once per frame
    void Update()
    {
        hit(0);
       if(player_health == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
    public void hit()
    {
        hit(-1);
    }
    public void hit(int adj)
    {
        player_health += adj;
        if(player_health < 0)
        {
            player_health = 0;
        }
        if(player_health > maxHealth)
        {
            player_health = maxHealth;
        }
        if (maxHealth < 1)
            maxHealth = 1;
        healthBarlength = (Screen.width / 2) * (player_health / (float)maxHealth);
    }
}
