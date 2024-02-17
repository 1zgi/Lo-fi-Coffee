using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static FilterMachineUI;
using static EspressoMachine;

public class buttonAction : MonoBehaviour
{
	public FilterMachineUI filter;
	public EspressoMachine espresso;
	public bool check = false;
	public bool clicked_shotCup = false;
	public bool checkmilk_pitcher_esp = false;
	public bool checkmilk = false;
	public bool  clicked_water = false;

	public void buttonMethode()
	{
		Debug.Log("Done");
		check = true; //check coffe full button clicked
	}

	public void  ClickedMilk()
	{
		if(check)
		{
			filter.filterWith_milk.SetActive(true);
			checkmilk  = true;//Check Milk button clicked
			Checkbutton();
		}
	}

	public void Clicked_esp()
	{
		clicked_shotCup = false;
	}


	public void ClickedMilk_esp()
	{
		espresso.cubuk.SetActive(true);
		checkmilk_pitcher_esp = true;
	}

	public void ClickedShotCup_esp()
	{
			clicked_shotCup = true;
	}

	public void ClickedWater_esp()
	{
		if(clicked_shotCup)
		{
			espresso.americano.SetActive(true);
			espresso.espresso.SetActive(false);
			clicked_shotCup = false;
		}
		
	}

	public void SetActive()
	{
		if(checkmilk_pitcher_esp && clicked_shotCup)
		{
			espresso._Latte.SetActive(true);
			espresso.espresso.SetActive(false);
		}

	}

	public void Check_buttonWater()
	{
		if (clicked_shotCup)
			clicked_water = false;
	}

	public void Checkbutton_kasik()
	{
		if (checkmilk_pitcher_esp)
		{
			checkmilk_pitcher_esp = false;
		}
	}

	public void Checkbutton()
	{
		check = false;
	}


    public void  Clicked_Drink()  //  Is drink clicked?
	{
		if(check)
		{
			print("clicked_soft_filter");
			Checkbutton();
		}

		if (checkmilk)
		{
			print("cliced_milk_filter");
			checkmilk = false;
			Checkbutton();
		}

	}
}
