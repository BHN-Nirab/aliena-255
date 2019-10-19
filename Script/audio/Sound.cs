using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SocialPlatforms;

public class Sound : MonoBehaviour
{
    public static AudioSource theme;

    public bool isPlayingIntro = true;
    private float themeVol = 1.0f;
    private float minThemeVol = 0.2f;
    private float maxThemeVol = 1.0f;

     void Update()
     {
         if (gameObject.GetComponent<AudioSource>().isPlaying)
         {
             theme.volume = themeVol;
             themeVol -= 0.01f;
             if (themeVol < minThemeVol) themeVol = minThemeVol;
         }
         else
         {
             theme.volume = themeVol;
             themeVol += 0.01f;
             if (themeVol > maxThemeVol) themeVol = maxThemeVol;
         }
     }
    
     
}
