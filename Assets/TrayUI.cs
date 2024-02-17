using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrayUI : MonoBehaviour
{
	public GameObject Tray2DUI;
	public GameObject selectionManager;

	[Header("Inventory Objects")]
	public GameObject milk_filter;
	public GameObject soft_filter;
	public GameObject espresso_soft;
	public GameObject latte;
	public GameObject icelatte;
	public GameObject iceAmericano;
	public GameObject americano;
	public GameObject donut;
	public GameObject cupcake;
	public GameObject cake;


	public Button close;

	void Start()
	{
		close.onClick.AddListener(CloseTrayWindow);
	}

	public void OpenTrayWindow()
	{
		selectionManager.SetActive(false);
		Tray2DUI.SetActive(true);
	}

	public void CloseTrayWindow()
	{
		selectionManager.SetActive(true);
		Tray2DUI.SetActive(false);
	}




}
