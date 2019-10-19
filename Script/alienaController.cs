using System;
using System.Threading.Tasks;
using UnityEngine;
using Random = System.Random;

public class alienaController : MonoBehaviour
{
    public CharacterController characterController;
    public Animator anim;
    public Transform player;
    public Vector3 moveDirection;
    public float speed = 3.0f;
    public bool isMoved;
    public String currentState;

    public GameObject[] targets;
    private bool[] isReachedTargets = new bool[10];
    private bool[] isExcecutedTargerTask = new bool[10];
    private int currentTargetIndex;


    private bool isRotatedForAnim = false;
    private bool isCalledM1 = false;
    private float turnAngle = 0.0f;
    private bool checkTurn = false;

    public void Start()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        
        moveDirection = Vector3.zero;
        isMoved = false;
        currentState = "idle";

        currentTargetIndex = 0;

        for (int i = 1; i <= 9; i++)
        {
            isReachedTargets[i] = false;
            isExcecutedTargerTask[i] = false;
        }
            
    }
    
    public void Update()
    {
        calculateDistanceFromTarget();
        if (checkTurn)
        {
             transform.Rotate(0, turnAngle, 0);
             checkTurn = false;
        }
           
        float distanceFromPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceFromPlayer <= 5.0f)
        {
            if (isReachedTargets[1] && !isExcecutedTargerTask[1])
            {

                if (currentState != "turnRight")
                {
                    anim.SetTrigger(currentState + "To" + "turnRight");
                    currentState = "turnRight";
                }

                if (!isRotatedForAnim)
                {
                    turnAngle = 82;
                    transform.Rotate(0,turnAngle,0);
                    turnAngle = 0;
                    isRotatedForAnim = true;
                }
                
                
                if (currentState != "pointing")
                {
                    anim.SetTrigger(currentState + "To" + "pointing");
                    currentState = "pointing";
                }


                // isExcecutedTargerTask[1] = true;

            }
            else
            {
                moveAliena();
            }
            
        }
        else
        {
            if (currentState != "angry")
            {
                anim.SetTrigger(currentState + "To" + "angry");
                currentState = "angry";
            }
            
        }
            
    }

    private void calculateDistanceFromTarget()
    {
        /*
         * Target_1 = 4.00
         * Target_2 = 4.50
         * Target_3 = 6.20
         * Target_4 = 5.72
         * Target_5 = 6.00
         * Target_6 = 7.24
         * Target_7 = 6.88
         * Target_8 = 8.36
         * Target_9 = 9.00
         */
        
        float[] distances = new float[10];

        for (int i = 1; i <= 9; i++)
        {
            distances[i] = Vector3.Distance(targets[i].transform.position, transform.position);
        }
       // print("Target_9" + " : " + distances[9] + " --> " + DateTime.Now.ToString());
        

        if (distances[1] <= 4.00f)
        {
            isReachedTargets[1] = true;
            currentTargetIndex++;
        }

        if (distances[2] <= 4.50f)
        {
            isReachedTargets[2] = true;
            currentTargetIndex++;
        }

        if (distances[3] <= 6.20f)
        {
            isReachedTargets[3] = true;
            currentTargetIndex++;
        }

        if (distances[4] <= 5.72f)
        {
            isReachedTargets[4] = true;
            currentTargetIndex++;
        }
        
        if (distances[5] <= 6.00f)
        {
            isReachedTargets[5] = true;
            currentTargetIndex++;
        }
        
        if (distances[6] <= 7.24f)
        {
            isReachedTargets[6] = true;
            currentTargetIndex++;
        }
        
        if (distances[7] <= 6.88f)
        {
            isReachedTargets[7] = true;
            currentTargetIndex++;
        }
        
        if (distances[8] <= 8.36f)
        {
            isReachedTargets[8] = true;
            currentTargetIndex++;
        }
        
        if (distances[9] <= 9.00f)
        {
            isReachedTargets[9] = true;
            currentTargetIndex++;
        }
            

    }
    

    void moveAliena()
    {
        // toogle between vr and key
        
        //Vector3 direction = moveDirectionVR(); 
        Vector3 direction = moveDirectionKey();
        
        moveDirection = transform.TransformDirection(direction);
        moveDirection *= speed;

        if (isMoved)
        {
            if (currentState != "walking")
            {
                anim.SetTrigger(currentState + "To" + "walking");
                currentState = "walking";
            }
            
            characterController.Move(moveDirection * Time.deltaTime);
        }
        else
        {
            if (currentState != "idle")
            {
                anim.SetTrigger(currentState + "To" + "idle");
                currentState = "idle";
            }
        }

        rotateAliena();
        
    }

    private void rotateAliena()
    {
        if (isReachedTargets[3])
        {
            if (!isExcecutedTargerTask[3])
            {
                transform.Rotate(0, 82, 0);
                isExcecutedTargerTask[3] = true;
            }
        }
        
        if (isReachedTargets[4])
        {
            if (!isExcecutedTargerTask[4])
            {
                transform.Rotate(0, -85, 0);
                isExcecutedTargerTask[4] = true;
            }
        }
        
        if (isReachedTargets[6])
        {
            if (!isExcecutedTargerTask[6])
            {
                transform.Rotate(0, -85, 0);
                isExcecutedTargerTask[6] = true;
            }
        }
        
        if (isReachedTargets[8])
        {
            if (!isExcecutedTargerTask[8])
            {
                transform.Rotate(0, 77, 0);
                isExcecutedTargerTask[8] = true;
            }
        }
    }
    

    private Vector3 moveDirectionVR()
    {
        float x = 0, z = 0;
        if (player.eulerAngles.x >= 15.0f && player.eulerAngles.x < 90.0f)
        {
            z = Vector3.forward.z;
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
            if (Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d"))
            {
                z = Vector3.forward.z;
                isMoved = true;
            }
            else
            {
                isMoved = false;
            }
            
            return new Vector3(x, 0, z);
    }
    


}



