using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = System.Random;
using Random2 = UnityEngine.Random;

public class VRLookMove : MonoBehaviour
{
    public float speed = 10.0f;
    public Transform vrCamera;
    public Transform spaceShip;
    
    // DashBoard UI
    private bool isDashBoardOpen = false;
    private bool isMoveLeft = false;
    private bool isMoveRight = false;
    private bool isMoveUp = false;
    private bool isMoveDown = false;
    private bool isMoveForward = false;
    private bool isMoveBackward = false;
    public GameObject[] planets;
    public GameObject manualControlDashboard;
    public GameObject locationDashBoard;
    public Text LevelValue;
    
    // Orbit counter
    public int playerLocationinOrbit;
    public GameObject MyLocation;
    public Text NearbyPlanet;
    public int DistanceOfNearbyPlanet;
    public Text DisplayDistance;
    public GameObject needleTransfrom;

    private const float MAX_SPEED_ANGLE = -160.22f;
    private const float ZERO_SPEED_ANGLE = 73.51f;

    private float needleSpeedMax;
    private float needleSpeed;

    public bool isAutoMove = false;
    public bool isManualMove = false;

    public bool isShowInfoButtonClick = false;
    public Text showInfoButtonText;

     void Awake()
    {
    }

    void Start()
    {
        needleSpeed = 0.0f;
        needleSpeedMax = 200.0f;
        
        countOrbit();
        updateMyLocation();
        manualControlDashboard.SetActive(false);
        locationDashBoard.SetActive(true);
        
    }

    void Update()
    {
        int Yposition = (int) transform.position.y;
        LevelValue.text = Yposition.ToString();
        countOrbit();
        controllVRMovement();

        setNeedleMax();
        handleNeedleRotation();
        needleTransfrom.transform.localEulerAngles = new Vector3(0, 0, GetSpeedRotation());
        
        if (isDashBoardOpen == false)
        {
            float distance = Vector3.Distance(transform.position, GameObject.FindWithTag("sun").transform.position);
            
            if (distance > 32)
            {
                movePlayerUsingKey();
                movePlayerUsingVR();
            }
            else 
            {
                transform.Translate(Vector3.back);
            }
            
            GameObject.FindWithTag("solarSystemRoot").GetComponent<InfoPanelValue>().loadInfoValue();
        }

        else
        {
            if(isMoveLeft)
                transform.Translate(-0.1f, 0.0f, 0.0f);
            else if(isMoveRight)
                transform.Translate(0.1f, 0.0f, 0.0f);
            else if(isMoveUp)
                transform.Translate(0.0f, 0.1f, 0.0f);
            else if(isMoveDown)
                transform.Translate(0.0f, -0.1f, 0.0f);
            else if(isMoveForward)
                transform.Translate(0.0f, 0.0f, 0.1f);
            else if(isMoveBackward)
                transform.Translate(0.0f, 0.0f, -0.1f);

        }
        
    }
    

    public void LateUpdate()
    {
        updateMyLocation();
    }

    private float GetSpeedRotation() {
        float totalAngleSize = ZERO_SPEED_ANGLE - MAX_SPEED_ANGLE;

        float speedNormalized = needleSpeed / needleSpeedMax;

        return ZERO_SPEED_ANGLE - speedNormalized * totalAngleSize;
    }

    private void setNeedleMax()
    {
        if (isAutoMove)
            needleSpeedMax = 140;
        else if (isManualMove)
            needleSpeed = 80;
    }

    public void setShowInfoButton()
    {
        isShowInfoButtonClick = !isShowInfoButtonClick;

        if (isShowInfoButtonClick)
            showInfoButtonText.text = "Hide Info";
        else
            showInfoButtonText.text = "Show Info";
    }

    private void handleNeedleRotation()
    {
        if (isAutoMove || isManualMove) {
            float acceleration = 80f;
            needleSpeed += acceleration * Time.deltaTime;
        } else {
            float deceleration = 20f;
            needleSpeed -= deceleration * Time.deltaTime;
        }

        if (!isAutoMove && !isManualMove) {
            float brakeSpeed = 100f;
            needleSpeed -= brakeSpeed * Time.deltaTime;
        }

        needleSpeed = Mathf.Clamp(needleSpeed, 0f, needleSpeedMax);
    }

    public void updateMyLocation()
    {
        if (playerLocationinOrbit == 1)
        {
            MyLocation.transform.localPosition = new Vector3(-6.06f, -11.8f, 0.0f);
            NearbyPlanet.text = "MERCURY";
            DistanceOfNearbyPlanet = (int) Vector3.Distance(planets[0].transform.position, transform.position);
        }
            
        else if (playerLocationinOrbit == 2)
        {
            MyLocation.transform.localPosition = new Vector3(-6.06f, -21.5f, 0.0f);
            NearbyPlanet.text = "VENUS";
            DistanceOfNearbyPlanet = (int) Vector3.Distance(planets[1].transform.position, transform.position);
        }
            
        else if (playerLocationinOrbit == 3)
        {
            MyLocation.transform.localPosition = new Vector3(-6.06f, -31.2f, 0.0f);
            NearbyPlanet.text = "EARTH";
            DistanceOfNearbyPlanet = (int) Vector3.Distance(planets[2].transform.position, transform.position);
        }
            
        else if (playerLocationinOrbit == 4)
        {
             MyLocation.transform.localPosition = new Vector3(-6.06f, -42.5f, 0.0f);
             NearbyPlanet.text = "MARS";
             DistanceOfNearbyPlanet = (int) Vector3.Distance(planets[3].transform.position, transform.position);
        }
           
        else if (playerLocationinOrbit == 5)
        {
            MyLocation.transform.localPosition = new Vector3(-6.06f, -54.1f, 0.0f);
            NearbyPlanet.text = "JUPITER";
            DistanceOfNearbyPlanet = (int) Vector3.Distance(planets[4].transform.position, transform.position);
        }
            
        else if (playerLocationinOrbit == 6)
        {
             MyLocation.transform.localPosition = new Vector3(-6.06f, -65.8f, 0.0f);
             NearbyPlanet.text = "SATURN";
             DistanceOfNearbyPlanet = (int) Vector3.Distance(planets[5].transform.position, transform.position);
        }
           
        else if (playerLocationinOrbit == 7)
        {
            MyLocation.transform.localPosition = new Vector3(-6.06f, -82.2f, 0.0f);
            NearbyPlanet.text = "URANUS";
            DistanceOfNearbyPlanet = (int) Vector3.Distance(planets[6].transform.position, transform.position);
        }
            
        else if (playerLocationinOrbit == 8)
        {
            MyLocation.transform.localPosition = new Vector3(-6.06f, -95.6f, 0.0f);
            NearbyPlanet.text = "NEPTUNE";
            DistanceOfNearbyPlanet = (int) Vector3.Distance(planets[7].transform.position, transform.position);
        }

        DisplayDistance.text = DistanceOfNearbyPlanet.ToString();

    }

    public void countOrbit()
    {
        float distance = Vector3.Distance(GameObject.FindWithTag("sunsphere").transform.position, transform.position);

        if (distance <= 155.0f)
            playerLocationinOrbit = 1;
        else if (distance <= 180.0f)
            playerLocationinOrbit = 2;
        else if (distance <= 210.0f)
            playerLocationinOrbit = 3;
        else if (distance <= 261.0f)
            playerLocationinOrbit = 4;
        else if (distance <= 341.0f)
            playerLocationinOrbit = 5;
        else if (distance <= 419.0f)
            playerLocationinOrbit = 6;
        else if (distance <= 474.0f)
            playerLocationinOrbit = 7;
        else if (distance <= 524.0f)
            playerLocationinOrbit = 8;
        else
            playerLocationinOrbit = 9;
    }

    public void controllVRMovement()
    {
        bool isStop = false;
        
        for (int i = 0; i < 8; i++)
        {
            if (planets[i].GetComponent<OrbitController>().stop == 0.0f)
            {
                isStop = true;
                break;
            }

        }

        if (isStop)
        {
            isDashBoardOpen = true;
            manualControlDashboard.SetActive(true);
            locationDashBoard.SetActive(false);
        }

        else
        {
            isDashBoardOpen = false;
            manualControlDashboard.SetActive(false);
            locationDashBoard.SetActive(true);
        }
            
    }

    public void moveLeft()
    {
        isMoveLeft = true;

        isMoveRight = false;
        isMoveUp = false;
        isMoveDown = false;
        isMoveForward = false;
        isMoveBackward = false;
        
        isAutoMove = false;
        isManualMove = true;
    }
    
    public void moveRight()
    {
        isMoveRight = true;

        isMoveLeft = false;
        isMoveUp = false;
        isMoveDown = false;
        isMoveForward = false;
        isMoveBackward = false;
        
        isAutoMove = false;
        isManualMove = true;

    }
    
    public void moveForward()
    {
        isMoveForward = true;

        isMoveRight = false;
        isMoveUp = false;
        isMoveDown = false;
        isMoveLeft = false;
        isMoveBackward = false;
        
        isAutoMove = false;
        isManualMove = true;
    }
    
    public void moveBackward()
    {
        isMoveBackward = true;

        isMoveRight = false;
        isMoveUp = false;
        isMoveDown = false;
        isMoveForward = false;
        isMoveLeft = false;
        
        isAutoMove = false;
        isManualMove = true;
    }
    public void moveUp()
    {
        isMoveUp = true;

        isMoveRight = false;
        isMoveLeft = false;
        isMoveDown = false;
        isMoveForward = false;
        isMoveBackward = false;
        
        isAutoMove = false;
        isManualMove = true;
    }
    public void moveDown()
    {
        isMoveDown = true;

        isMoveRight = false;
        isMoveUp = false;
        isMoveLeft = false;
        isMoveForward = false;
        isMoveBackward = false;

        isAutoMove = false;
        isManualMove = true;
    }

    public void stopMove()
    {
        isAutoMove = false;
        isManualMove = false;
        isMoveLeft = false;
        isMoveRight = false;
        isMoveUp = false;
        isMoveDown = false;
        isMoveForward = false;
        isMoveBackward = false;
    }
    

    void movePlayerUsingKey()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        
        transform.Translate(horizontal, 0.0f, 0.0f);
        transform.Translate(0.0f, 0.0f, vertical);
        
        if(Input.GetKey("e"))
            transform.Translate(0,0.1f, 0);
        if(Input.GetKey("x"))
            transform.Translate(0,-0.1f,0);

    }

    void movePlayerUsingVR()
    {
        if (vrCamera.eulerAngles.x >= 20.0f)
        {
            transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
            isAutoMove = true;
            isManualMove = false;
        }
        else
        {
            isAutoMove = false;
        }
    }
    
  
    
}