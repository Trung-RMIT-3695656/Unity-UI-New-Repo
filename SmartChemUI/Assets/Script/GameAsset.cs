using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAsset : MonoBehaviour
{
    private static GameAsset reference;

    public static GameAsset Instance
    {
        get
        {
            if (reference == null) reference = (Instantiate(Resources.Load("GameAsset")) as GameObject).GetComponent<GameAsset>();
            return reference;
        }
    }

    public Sprite 
}
