using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateAsteroid : MonoBehaviour
{

    public Transform asteroid;
    public int fieldRadius = 1000;
    public int asteroidCount = 3000;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < asteroidCount; i++)
        {
            Transform temp = Instantiate(asteroid, Random.insideUnitSphere * fieldRadius, Random.rotation);
            temp.localScale = temp.localScale * Random.Range(0.5f, 5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
