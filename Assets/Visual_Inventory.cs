using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using static TrayUI;

public class Visual_Inventory : MonoBehaviour
{
    private bool Soft_Filter = false;
    private bool Filter_with_Milk = false;
    private bool Espresso = false;
    private bool _Latte = false;
    private bool Ice_Latte = false;
    private bool _Americano = false;
    private bool Ice_Americano = false;
    private bool Ice = false;
    public TrayUI inventory;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkInventory();
    }

    public void checkInventory()
	{
        if (Ice && _Latte)
        {

            IceLatte();

        }


        if (Ice && _Americano)
		{
            IceAmericano();
        }
           
      /*
        if(Ice && _Americano && _Latte)
		{

		}

      */

    }


    public void Filter()
	{
        Soft_Filter = true;
        print("Filter added in Inventory ");
        inventory.soft_filter.SetActive(true);
	}

    public void Filter_Milk()
    {
        Filter_with_Milk = true;
        print("FilterMilk added in Inventory ");
        inventory.milk_filter.SetActive(true);
    }

    public void Americano()
    {
        _Americano = true;
        print("Americano added in Inventory ");
        inventory.americano.SetActive(true);
    }

    public void IceAmericano()
    {
        Ice_Americano = true;
        print("Ice Americano added in Inventory ");
        inventory.iceAmericano.SetActive(true);
        inventory.americano.SetActive(false);
        _Americano = false;
        UsedIceToCoffe();
    }

    public void Soft_Espresso()
    {
        Espresso = true;
        print("Espresso added in Inventory ");
        inventory.espresso_soft.SetActive(true);
    }

    public void Latte()
    {
        _Latte = true;
        print("Latte added in Inventory ");
        inventory.latte.SetActive(true);
    }

    public void IceLatte()
    {
        Ice_Latte = true;
        print("Ice Latte added in Inventory ");
        inventory.icelatte.SetActive(true);
        inventory.latte.SetActive(false);
        _Latte = false;
        UsedIceToCoffe();
    }

    public void Donut()
    {
        print("Donut added in Inventory");
        inventory.donut.SetActive(true);
    }

    public void CupCake()
    {
        print("Cupcake added in Inventory");
        inventory.cupcake.SetActive(true);
    }

    public void CarrotCake()
    {
        print("CarrotCake added in Inventory");
        inventory.cake.SetActive(true);
    }



    public void AddIceToCoffe()
	{
        Ice = true;
        print("Ice Added");

    }

    public void UsedIceToCoffe()
    {
        Ice = false;
        print("Ice Used");

    }


    public void Reset()
	{
       Soft_Filter = false;
       Filter_with_Milk = false;
       Espresso = false;
       _Latte = false;
       Ice_Latte = false;
      _Americano = false;
      Ice_Americano = false;
      Ice = false;

    }


}
