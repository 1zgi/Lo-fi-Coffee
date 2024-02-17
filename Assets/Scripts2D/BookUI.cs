using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookUI : MonoBehaviour
{
	public GameObject book2DUI;
	public GameObject selectionManager;

	public Button close;

	void Start()
	{
		close.onClick.AddListener(CloseBookMachineWindow);
	}

	public void OpenBookMachineWindow()
	{
		selectionManager.SetActive(false);
		book2DUI.SetActive(true);
	}

	public void CloseBookMachineWindow()
	{
		selectionManager.SetActive(true);
		book2DUI.SetActive(false);
	}
}
