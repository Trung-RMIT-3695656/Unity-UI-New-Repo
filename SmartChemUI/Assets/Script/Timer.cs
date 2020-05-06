using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public float TimeLeft = 3.0f;
    // public Text startText;
    public Text endText;

    void Update()
    {
        TimeLeft -= Time.deltaTime;
        // startText.text = (TimeLeft).ToString("0");
        endText.text = (TimeLeft).ToString("0");
        if (TimeLeft < 0)
        {
            // if time is in 0
            // the player will be hurt by the monster
        }
    }
}
