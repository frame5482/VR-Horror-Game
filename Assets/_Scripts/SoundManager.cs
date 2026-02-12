using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip burnpaper;
    public AudioClip wingame;

    public void BurnPaper()
    {
        audio.clip = burnpaper;
        audio.Play();
    }

    public void ClearGame()
    {
        audio.clip = wingame;
        audio.Play();
    }
}
