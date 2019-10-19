using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAsteroids : MonoBehaviour
{
    public float minSpinSpeed = 1f;
    public float maxSpinSpeed = 5f;
    public float minThrust = 0.1f;
    public float maxThrust = 0.5f;
    private float spinSpeed;

    void Start()
    {
        spinSpeed = Random.Range(minSpinSpeed, maxSpinSpeed);
        float thrust = Random.Range(minThrust, maxThrust);
    }

    void Update()
    {
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
    }
}
