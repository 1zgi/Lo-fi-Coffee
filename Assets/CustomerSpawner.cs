using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CustomerOrder;


public class CustomerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject CustomerPrefab;
    [SerializeField] private GameObject Customer;
    public Transform waypointSpawner;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void SpawnCustomer()
    {
        Customer = Instantiate(CustomerPrefab, waypointSpawner.transform.position, Quaternion.identity);
    }

    public void DestroyCustomer()
    {
        if(Customer!=null)
		{
            Destroy(Customer);
		}
    }

    public void RespawnCustomer()
	{
        DestroyCustomer();
        SpawnCustomer();
    }
}
