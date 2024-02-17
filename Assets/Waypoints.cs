using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CustomerAI;

public class Waypoints : MonoBehaviour
{
	[Range(0f, 2f)]
	[SerializeField] private float waypointSize = 1f;
	private Transform currentpoint;
	public CustomerAI customer;
	private string tagwaypoints;

	private  void OnDrawGizmos()
	{
		foreach(Transform t in transform)
      	{
			Gizmos.color = Color.blue;
			Gizmos.DrawWireSphere(t.position, waypointSize);

		}

		Gizmos.color = Color.red;
		for(int  i =  0;i<transform.childCount - 1;i++)
		{
			Gizmos.DrawLine(transform.GetChild(i).position, transform.GetChild(i + 1).position);
		}

	}

	public Transform GetNextWaypoint(Transform currentWaypoint)
	{

		if (currentWaypoint == null)
		{
			return transform.GetChild(0);
		}

		tagwaypoints = currentWaypoint.tag;
		print(tagwaypoints);
		

		//Add a statment which will provide to get next waypoint
		
		if (currentWaypoint.GetSiblingIndex() < transform.childCount - 1)
		{
			CustomerAI customerAI = FindObjectOfType<CustomerAI>();
			customerAI.OnWaypointTagUpdated(tagwaypoints);
			return transform.GetChild(currentWaypoint.GetSiblingIndex() + 1);
		}
		else
		{
			return transform.GetChild(0);
		}


	}



}
