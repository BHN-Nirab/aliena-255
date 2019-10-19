using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class VRLookWalk : MonoBehaviour
{
    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float speed = 3.0f;
    public bool moveForward;

    private CharacterController cc;
    
    
    //for keyboard
    private bool moveBackward = false;
    private bool moveright = false;
    private bool moveleft = false;
    
    private bool stopforever = false;

    public Animator anim;

    void Start()
    {
        cc = GetComponent<CharacterController>();
        moveForward = false;
    }

    void Update()
    {
        // toogle between vr and key

        float distance = Vector3.Distance(transform.position, GameObject.FindWithTag("launch").transform.position);

        if (distance <= 2.0f)
        {
            stopforever = true;
            anim.SetTrigger("fadeout");
        }

        else if(!stopforever)
        {
            handleMovementInKey();
            handleMovementInVR();
        }
        
    }


    void handleMovementInVR()
    {
        if (vrCamera.eulerAngles.x >= 15.0f && vrCamera.eulerAngles.x < 90.0f)
            speed = 3;
        if (vrCamera.eulerAngles.x >= 20.0f && vrCamera.eulerAngles.x < 90.0f)
            speed = 4;
        if (vrCamera.eulerAngles.x >= 25.0f && vrCamera.eulerAngles.x < 90.0f)
            speed = 5;
        if (vrCamera.eulerAngles.x >= 30.0f && vrCamera.eulerAngles.x < 90.0f)
            speed = 6;
        
        if (vrCamera.eulerAngles.x >= 15.0f && vrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;
        }
        

        else
        {
            moveForward = false;
        }

        if (moveForward )
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);
        }
    }

    void handleMovementInKey()
    {
        if (Input.GetKey("1"))
            speed = 3;
        if (Input.GetKey("2"))
            speed = 4;
        if (Input.GetKey("3"))
            speed = 5;
        if (Input.GetKey("4"))
            speed = 6;
        
        if (Input.GetKey("w"))
        {
            moveForward = true;
        }

        else
        {
            moveForward = false;
        }
        
        if (Input.GetKey("d"))
        {
            moveright = true;
        }
        else
        {
            moveright = false;
        }

        if (Input.GetKey("a"))
        {
            moveleft = true;
        }
        else
        {
            moveleft = false;
        }

        if (Input.GetKey("s"))
        {
            moveBackward = true;
        }
        else
        {
            moveBackward = false;
        }

        if (moveForward )
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);
        }
        
        else if (moveBackward )
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.back);

            cc.SimpleMove(forward * speed);
        }
        else if (moveright )
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.right);

            cc.SimpleMove(forward * speed);
        }
        else if (moveleft )
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.left);

            cc.SimpleMove(forward * speed);
        }
        /*else
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * 0.5f);
        }*/
    }
}
