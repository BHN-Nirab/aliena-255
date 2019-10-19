using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{ 
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        Sound.theme = gameObject.GetComponent<AudioSource>();
    }

}
