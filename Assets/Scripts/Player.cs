using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.AI;
using static AnimatorPlayer;
using System;


public class Player : MonoBehaviour
{
    public AnimatorPlayer animator;
    public LayerMask whatCanBeClickedOn;
    private NavMeshAgent myAgent;
    public Camera playerCamera;


    private int clickdistance = 100;
    private  bool  cheked  = false;

    Vector3 agentposition;
    Vector3 hitPoint;
    private bool isMoving = false;
    private Transform destination;


    void Start()
    {
        
        myAgent = GetComponent<NavMeshAgent>();
        agentposition = myAgent.transform.position;
    }

   
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
		{
           
            Ray myRay = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            

            if (Physics.Raycast(myRay, out hitInfo,clickdistance,whatCanBeClickedOn))
			{
               MoveToDestination(hitInfo.point);
                animator.SetAnimTrue();
            }

           

        }

        if(isMoving  &&  !myAgent.pathPending)
		{
           if(myAgent.remainingDistance<=myAgent.stoppingDistance)
			{
                animator.SetAnimFalse();
                isMoving = false;
                if (cheked)
                {
                    animator.DoingSomething();
                    cheked = false;
                }
                else
				{
                    animator.CloseDoingSomething();
                }
            }
		}
        
    }

    public bool AnimationAfterClicked(bool check)//animation  after clicked selectable objects
    {
        cheked = check;
        check  = false;
        return cheked;
    }



    void MoveToDestination(Vector3  targetPosition)
	{
        isMoving = true;
        destination = new GameObject().transform;
        destination.position  = targetPosition;
        myAgent.SetDestination(targetPosition);
        animator.CloseDoingSomething();
    }

    void OnDestroy()
	{
        if(destination!=null)
		{
            Destroy(destination.gameObject);
		}
	}

    public void ClosePlayerNav()
    {
        clickdistance = 1;
    }

    public void OpenPlayerNav()
    {
        clickdistance = 100;
    }

   
}
