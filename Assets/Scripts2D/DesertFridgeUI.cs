using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesertFridgeUI : MonoBehaviour
{

	public GameObject fridge2DUI;
	public GameObject selectionManager;

	[Header("Deserts")]
	public GameObject donut;
	public GameObject cupcake;
	public GameObject carrotcake;


	public Button close;

	void Start()
	{
		close.onClick.AddListener(CloseFridgeMachineWindow);
	}

	public void OpenFridgeMachineWindow()
	{
		selectionManager.SetActive(false);
		fridge2DUI.SetActive(true);
	}

	public void CloseFridgeMachineWindow()
	{
		selectionManager.SetActive(true);
		fridge2DUI.SetActive(false);
	}
}
