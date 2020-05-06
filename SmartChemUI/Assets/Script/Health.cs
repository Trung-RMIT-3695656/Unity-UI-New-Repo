using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health; // heart
    public int numOfHearts; // heart's Container 

    public Image[] hearts;
    public Sprite redHeart;
    public Sprite blackHeart;

    void Update()
    {
        if(health > numOfHearts)
        {
            health = numOfHearts; //restraint the number of hearts
        }

        for(int i = 0;i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = redHeart;
            }
            else
            {
                hearts[i].sprite = blackHeart;
            }

            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
