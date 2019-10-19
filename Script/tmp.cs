/*

using System;
using UnityEngine;
using Random = System.Random;

public class tmp : MonoBehaviour
{

    public bool isDebug;
    
    public CharacterController controller;
    public Transform player;
    private bool isMoved;
    public float speed;
    private Vector3 moveDirection;

    private bool isReachedWall1 = false;

    public void Start()
    {
        isDebug = true;
        
        controller = GetComponent<CharacterController>();
        speed = 3.0f;
        isMoved = false;
        moveDirection = Vector3.zero;
    }

    public void Update()
    {
        float distanceFromPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceFromPlayer <= 5.0f)
        {
            moveAliena();
        }
    }

    private void moveAlienaUsingKey()
    {
        if (Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d"))
        {
            if(!isReachedWall1)  
                controller.Move(Vector3.right * speed  * Time.deltaTime);
            else
            {
                controller.Move(Vector3.back * speed * Time.deltaTime);
            }
        }
            
        
        float distance = Vector3.Distance(GameObject.FindWithTag("wall1").transform.position, transform.position);
        if (distance <= 6)
        {
            if (!isReachedWall1)
            {
                transform.Rotate(0, 82,0);
                isReachedWall1 = true;
            }
        }
            

    }
    
    void moveAliena()
    {
        moveDirection = transform.TransformDirection(moveDirectionKey());
        moveDirection *= speed;
        if (isMoved)
            controller.Move(moveDirection * speed * Time.deltaTime);
    }
    
    private Vector3 moveDirectionKey()
    {
        float x = 0, y = 0, z = 0;
        if (Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d"))
        {
            z = Vector3.forward.z;
            isMoved = true;
        }
        else
        {
            isMoved = false;
        }
            
        return new Vector3(x, y, z);
    }
}

*/



//old code











/*
using System;
using UnityEngine;
using Random = System.Random;

public class alienaController : MonoBehaviour
{
    public CharacterController characterController;
    public Transform player;
    public Vector3 moveDirection;
    public float speed = 3.0f;
    public bool isMoved;

    public void Start()
    {
        characterController = GetComponent<CharacterController>();
        moveDirection = Vector3.zero;
        isMoved = false;
    }

    public void Update()
    {
        float distanceFromPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceFromPlayer <= 5.0f)
        {
            moveAliena();
            //rotateAliena();
        }
            
    }

    void rotateAliena()
    {
        rotateAlienaWithKey();
        //rotateAlienaWithVR();
    }

    void rotateAlienaWithKey()
    {
        float axis = Input.GetAxis("Horizontal");
        transform.right = Vector3.Slerp(transform.right, Vector3.right * axis, 0.1f);
    }

    void rotateAlienaWithVR()
    {
        //left
        if (player.eulerAngles.y <= 35.0f && player.eulerAngles.y > 0.0f)
        {
            float value = 35.0f - player.eulerAngles.y;
            value /= 35.0f;
            transform.right = Vector3.Slerp(transform.right, Vector3.right * value*(1), 0.1f);
        }
        
        //right
        if (player.eulerAngles.y >= 145.0f && player.eulerAngles.y < 175.0f)
        {
            float value = Math.Abs(145.0f - player.eulerAngles.y);
            value /= 30.0f;
            transform.right = Vector3.Slerp(transform.right, Vector3.right * value*(-1), 0.1f);
        }
    }

    void moveAliena()
    {
        moveDirection = transform.TransformDirection(moveDirectionKey());
        moveDirection *= speed;
        if (isMoved)
            characterController.Move(moveDirection * Time.deltaTime);
    }

    private Vector3 moveDirectionVR()
    {
        float x = 0, z = 0;
        if (player.eulerAngles.x >= 15.0f && player.eulerAngles.x < 90.0f)
        {
            z = Vector3.forward.z;
            isMoved = true;
        }
        else if (player.eulerAngles.y <= 35.0f && player.eulerAngles.y > 0.0f)
        {
            x = Vector3.left.x;
            isMoved = true;
        }
        else if (player.eulerAngles.y >= 145.0f && player.eulerAngles.y < 175.0f)
        {
            x = Vector3.right.x;
            isMoved = true;
        }
        
        else
        {
            isMoved = false;
        }
            
        return new Vector3(x, 0, z);
    }

    private Vector3 moveDirectionKey()
        {
            float x = 0, z = 0;
            if (Input.GetKey("w"))
            {
                z = Vector3.forward.z;
                isMoved = true;
            }
            else if (Input.GetKey("a"))
            {
                x = Vector3.left.x;
                isMoved = true;
            }
            else if (Input.GetKey("d"))
            {
                x = Vector3.right.x;
                isMoved = true;
            }
            else
            {
                isMoved = false;
            }
            
            return new Vector3(x, 0, z);
    }
    
    /*    public Transform player;
    private CharacterController cc;
    public Animator anim;
    public float speed = 3.0f;
    private bool hitPlane1 = false;
    private string currState;
    public Transform road;
    public string currRoad = "road1";
    
    void Start()
    {
        currRoad = "road1";
        cc = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        road = GameObject.FindWithTag("road1").transform;
        
        Vector3 move = transform.TransformDirection(Vector3.forward);
        cc.SimpleMove(move * speed);
    }
    
    void Update()
    {
        print(currRoad);
        if(currRoad == "road2")
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1, 1),transform.position.y, transform.position.z );
            
        else if (currRoad == "road1")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, -1, 1));
            print("baaaaaaaaaaaaaal");
        }
            
    
        float distanceFromPlayer = Vector3.Distance(transform.position, player.position);
    
        if (distanceFromPlayer <= 5)
        {
            if(currState == "walkingToAngry")
                anim.SetTrigger("angryToWalking");
            handleMovementInkey();
           //handleMovementInVR();
           // putAlienaOnTrack();
        }
        else
        {
            anim.SetTrigger("walkingToAngry");
            currState = "walkingToAngry";
        }
        
    }
    
    private bool rotateOnRoad = false;
    
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        road = hit.collider.transform;
        //print(road.transform.position.ToString() + " , "  + transform.position.ToString() + " -- "+ new Random().Next());
        
        if (hit.collider.name == "road2")
        {
            if (!rotateOnRoad)
            {
                transform.Rotate(transform.rotation.x, 82, transform.rotation.z);
                currRoad = "road2";
            }
                
            rotateOnRoad = true;
        }
    
        /*if(hit.collider.tag == "road")
            road = hit.collider.transform;
    
        if (hit.collider.name == "road2")
        {
            if (!hitPlane1)
            {
                //anim.SetTrigger("walkingToTurnRight");
              //  anim.SetTrigger("turnRightToWalking");
                transform.Rotate(transform.rotation.x, 82, transform.rotation.z);
                hitPlane1 = true;
            }
            
        }
        else
        {
            hitPlane1 = false;
        }#2#
    
    }	
    
    void handleMovementInVR()
    {
        //if((player.eulerAngles.x >= 15.0f && player.eulerAngles.x < 90.0f) && (player.eulerAngles.y >= 145.0f && player.eulerAngles.y < 175.0f))
           // transform.Rotate(player.rotation.x, player.rotation.y, player.rotation.z);
        
            if (player.eulerAngles.x >= 15.0f && player.eulerAngles.x < 90.0f)
            {
                Vector3 move = transform.TransformDirection(Vector3.forward);
                cc.SimpleMove(move * speed);
            }
            if (player.eulerAngles.y >= 145.0f && player.eulerAngles.y < 175.0f)
            {
                Vector3 move = transform.TransformDirection(Vector3.right);
                cc.SimpleMove(move * speed);
            }
            if (player.eulerAngles.y <= 35.0f && player.eulerAngles.y > 0.0f)
            {
                Vector3 move = transform.TransformDirection(Vector3.left);
                move = new Vector3(Mathf.Clamp(GameObject.Find("road1").transform.position.z, -1, 1), move.y, move.z);
                cc.SimpleMove(move * speed);
            } 
            /*
            if ((player.eulerAngles.y >= 250.0f && player.eulerAngles.y < 300.0f) || (player.eulerAngles.y <= -35.0f && player.eulerAngles.y >= -120.0f) )
            {
                Vector3 move = transform.TransformDirection(Vector3.back);
                cc.SimpleMove(move * speed);
            }
        #2#
    
        
    }
    
    void putAlienaOnTrack()
    {
       // print("Road : " + road.transform.position.ToString() + " , " + "Aliena: " + transform.position.ToString() + " , " + new Random().Next());
       //print(GameObject.Find("road1").transform.position.ToString());
        if (transform.position.z < road.position.z - 1)
        {
            Vector3 move = transform.TransformDirection(Vector3.left);
            cc.SimpleMove(move * speed);
        }
        
        else if (transform.position.z > road.position.z + 1)
        {
            Vector3 move = transform.TransformDirection(Vector3.right);
            cc.SimpleMove(move * speed);
        }
        
    }
    
    void handleMovementInkey()
    {
        
            if (Input.GetKey("w"))
            {
                Vector3 move = transform.TransformDirection(Vector3.forward);
                cc.SimpleMove(move * speed);
            }
            else if (Input.GetKey("a"))
            {
                Vector3 move = transform.TransformDirection(Vector3.left);
                move = new Vector3(Mathf.Clamp(GameObject.Find("road1").transform.position.z, -1, 1), move.y, move.z);
                cc.SimpleMove(move * speed);
            }
            else if (Input.GetKey("d"))
            {
                Vector3 move = transform.TransformDirection(Vector3.right);
                cc.SimpleMove(move * speed);
                move = new Vector3(Mathf.Clamp(GameObject.Find("road1").transform.position.z, -1, 1), move.y, move.z);
            }
            /*else if (Input.GetKey("s"))
            {
                Vector3 move = transform.TransformDirection(Vector3.back);
                cc.SimpleMove(move * speed);
            }
    
    }#1#


}



*/

