using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static Waypoints;
using static SelectionManager;
using static CustomerSpawner;
using static CustomerOrder;
using UnityEngine.EventSystems;
using TMPro;
using System;
using static CustomerAnimator;

public class CustomerAI : MonoBehaviour
{
    //-----------NavMesh--------------
    /*
     NavMeshAgent agent;
     public Transform[] waypoints;
     int waypointIndex;
     Vector3 target;

     void Start()
     {
         agent = GetComponent<NavMeshAgent>();
         UpdateDestination();
     }


     void Update()
     {
         if(Vector3.Distance(transform.position,target)<1)
         {
             IterateWaypointIndex();
             UpdateDestination();
         }
     }

     void  UpdateDestination()
     {
         target = waypoints[waypointIndex].position;
         agent.SetDestination(target);
     }

     void  IterateWaypointIndex()
     {
         waypointIndex++;
        /* if (waypointIndex == waypoints.Length)
         {
             waypointIndex = 0;
         }

     }
       */
    //------------------------------------------------

     public Waypoints waypoints;
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float distanceTheshold  = 0.1f;
    [SerializeField] private float duration = 0f;
    [SerializeField] private float elapsedTime = 40f;
    private  bool isRunning = false;
    bool way2 = false;

    public CustomerSpawner Spawner;
    public CustomerOrder order;
    private Transform currentWaypoints;//Current Waypoint target  that  the object is moving  towards
    bool isMoving =  true;
    bool arrivedWay= false;
    bool CheckOrdered;
    bool timercomplete = false;

    public CustomerAnimator animator;

    [Header("Time Text")]
    public TextMeshProUGUI timerText;

    [Header("Time")]
    public string minute = "0";
    public string second = "0";

    void  Start()
	{
        
        //Set initial  position  to the  first  way point
        currentWaypoints = waypoints.GetNextWaypoint(currentWaypoints);
        transform.position = currentWaypoints.position;

        //Set  next waypoint target
        currentWaypoints = waypoints.GetNextWaypoint(currentWaypoints);
        transform.LookAt(currentWaypoints);
    }

    void  Update()
	{
        if(isMoving)
		{
            animator.SetAnimFalse();
            float distance = Vector3.Distance(transform.position, currentWaypoints.position);
            transform.position = Vector3.MoveTowards(transform.position, currentWaypoints.position, moveSpeed * Time.deltaTime);
            if ( distance<= distanceTheshold)
            {
                currentWaypoints = waypoints.GetNextWaypoint(currentWaypoints);
                transform.LookAt(currentWaypoints);
                
            }

            
        }
       
        if(isRunning)
		{
           
            elapsedTime -=Time.deltaTime;
            animator.SetAnimTrue();
            int m = Convert.ToInt16(minute);
            int s = Convert.ToInt16(second);
            s = Convert.ToInt16(elapsedTime);
            second = Convert.ToString(s);
            minute = Convert.ToString(m);

            if (elapsedTime <= duration)
			{
                TimerCompleted();
                if (!isRunning)
                {

                    
                    if (way2)
                    {
                        CompareOrderManager compare = FindObjectOfType<CompareOrderManager>();
                        Spawner deleteObj = FindObjectOfType<Spawner>();                      
                        compare.Compare();
                        deleteObj.ResetMeals();
                        way2 = false;
                    }
                    arrivedWay = false;
                    isMoving = true;
                    TimerReset();
                    print(isMoving);
                }

               
                    
               

            }

            WriteTimer();
        }


    }

    public void OnWaypointTagUpdated(string tag)
    {
        if (tag == "Waypoint1")
        {
            isMoving = false;
            arrivedWay = true;
            CustomerOrder order = FindObjectOfType<CustomerOrder>();
            order.GetRandom();

        }

        if (tag == "Waypoint2")
        {
            isMoving = false;
            arrivedWay = true;
            way2 = true;
            elapsedTime=3f;
            StartTimer();
    
        }

        if (tag == "Waypoint3")
        {
            //Destroy  and respawn;
              
          // Spawner.SpawnCustomer();
        }
        
        print(tag);
    }

    public void  checkOrdered(bool checkorder)
	{
        
        CheckOrdered = checkorder;
        print(CheckOrdered);
        if (CheckOrdered)
        {
            StartTimer();     
        }
    }

    public void Reset()
	{
        isMoving = true;
        arrivedWay = false;
    }

    public void  StartTimer()
	{
        isRunning = true;
        timercomplete = false;
        animator.SetAnimTrue();
    }

    public void StopTimer()
    {
        isRunning = false;
        
    }

    private  void  TimerCompleted()
	{
        timercomplete = true;
        isRunning = false;
        elapsedTime = 40f;
        CustomerOrder Corder = FindObjectOfType<CustomerOrder>();
        Corder.ResetMAT();

    }

    public void TimerReset()
    {
        print("reset");
        int m = Convert.ToInt16(minute);
        int s = Convert.ToInt16(second);
        m = 0;
        s = 0;
        minute = Convert.ToString(m);
        second = Convert.ToString(s);
        WriteTimer();
    }

    public void WriteTimer()
	{
        if(!timercomplete)
		{
            timerText.text = minute.ToString().PadLeft(2, '0') + ":" + second.ToString().PadLeft(2, '0');
        }
        else
		{
            timerText.text = " ";
        }
        
    }

}

