using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
   
    public void changeScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    
}
