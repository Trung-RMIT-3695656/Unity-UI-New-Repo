using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MusicTransition
{
    public static void PlaySound()
    {
        GameObject soundGameObjject = new GameObject("Sound");
        AudioSource audioSource = soundGameObjject.AddComponent<AudioSource>();
        audioSource.PlayOneShot()
    }

    
}
