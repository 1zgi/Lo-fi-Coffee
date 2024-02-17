using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EspressoMachine : MonoBehaviour
{
	[Header("Coffee")]
	
	
	public GameObject espresso;
	public GameObject _Latte;
	public GameObject americano;

	[SerializeField] private GameObject Milk;
	[SerializeField] private GameObject empty_cup;
	public GameObject shot_esp;
	public GameObject pitcherWith_milk;
	public GameObject pitcherWith_milk_button;
	
	public GameObject cubuk;
	public GameObject espresso2DUI;
	public GameObject selectionManager;


	public Button close;

	void Start()
	{
		close.onClick.AddListener(CloseEspressoMachineWindow);
		
	}


	public void OpenEspressoMachineWindow()
	{
		selectionManager.SetActive(false);
		espresso2DUI.SetActive(true);
	}

	public void CloseEspressoMachineWindow()
	{
		selectionManager.SetActive(true);
		espresso2DUI.SetActive(false);
	}

}
