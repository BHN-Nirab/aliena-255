using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class faderCon : MonoBehaviour
{ 
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        if(anim!=null)
         anim = GameObject.FindWithTag("solarFader").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fadeout()
    {
        GameObject.Find("faderPref").SetActive(true);
        anim.SetTrigger("fadeout");
    }

    public void changeSceneFromSolartoEarth()
    {
        SceneManager.LoadScene(0);
    }
}
