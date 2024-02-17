using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using System;

public class FilterMachineUI : MonoBehaviour
{
	[SerializeField] private Button Machine_open;
	[SerializeField] private Button Machine_close;
	[SerializeField] private Button Milk;
	[SerializeField] private Button coffeefull;
	[SerializeField] private Button empty_cup;
	[SerializeField] private Button soft_filter;
	[SerializeField] public GameObject filterWith_milk;
	public GameObject filter2DUI;
	public GameObject selectionManager;
	//public GameObject ButtonManager;
	public Button closeUI;
	
	void Start()
	{
		closeUI.onClick.AddListener(CloseFilterMachineWindow);
	
	}

	public void OpenFilterMachineWindow()
	{
		selectionManager.SetActive(false);
		filter2DUI.SetActive(true);	
	}

	public void CloseFilterMachineWindow()
	{
		selectionManager.SetActive(true);
		filter2DUI.SetActive(false);
	}


	void Update()
	{
	
		  
		
	}


}
