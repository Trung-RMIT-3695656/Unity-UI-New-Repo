using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public Canvas canvas;
    public bool isAchieved = false;

    public void popUp()
    {
        if (isAchieved == false)
        {
            isAchieved = true;
            canvas.enabled = true;
        }
    }

    public void exitPopup()
    {
        if (isAchieved == true)
        {
            canvas.enabled = false;
        }
    }
}
