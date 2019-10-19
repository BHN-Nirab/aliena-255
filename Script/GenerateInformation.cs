using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class GenerateInformation : MonoBehaviour
{
    void Update()
    {
        float distance = Vector3.Distance(GameObject.Find("tmp1").transform.position,
            GameObject.FindWithTag("Player").transform.position);
        
        print("Distance is: " + distance + " " + new Random().Next());
        
    }
}
