using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using static TrayUI;
using static CompareOrderManager;

public class Spawner : MonoBehaviour
{
    public GameObject Coffeprefab;
    public GameObject IceCoffeprefab;
    public GameObject Donutfab;
    public GameObject CupCakeprefab;
    public GameObject CarrotCakeprefab;

    [Header("Current Objects First Location")]
    public GameObject Espresso ;
    public GameObject Filter;
    public GameObject FilterMilk ;
    public GameObject Latte ;
    public GameObject IceLatte;
    public GameObject IceAmericano;
    public GameObject Americano;
    public GameObject Donut;
    public GameObject CupCake;
    public GameObject CarrotCake;

    [Header("Current Objects Second Location")]
    public GameObject Espresso2;
    public GameObject Filter2;
    public GameObject FilterMilk2;
    public GameObject Latte2;
    public GameObject IceLatte2;
    public GameObject IceAmericano2;
    public GameObject Americano2;
    public GameObject Donut2;
    public GameObject CupCake2;
    public GameObject CarrotCake2;

    public Vector3 spawnPosition;
    public TrayUI items;
    private bool islocation_1Empty = true;
    private bool islocation_2Empty = true;
    private bool isCofflocation_1Empty = true;
    private bool isCofflocation_2Empty = true;

    public string[] Meals = new string[4];
    int c=1;
    int i = 0;

    [Header("Coffee Spawn")]
    public GameObject CoffeespawnLocation_1;
    public GameObject CoffeespawnLocation_2;

    [Header("Deserts Spawn")]
    public GameObject DesertspawnLocation_1;
    public GameObject DesertspawnLocation_2;


    [Header("Deserts Spawn Location 1")]
    public GameObject donut_Loc1;
    public GameObject cupcake_Loc1;
    public GameObject cake_Loc1;

    [Header("Deserts Spawn Location 2")]
    public GameObject donut_Loc2;
    public GameObject cupcake_Loc2;
    public GameObject cake_Loc2;


    void Start()
    {
        Meals = new string[4];
    }

    // Update is called once per frame
    void Update()
    {

    }
    //---------Coffee Spawner-------------

    public void EspressoCoffeeSpawn()
    {
        string esp = "Espresso";

        if (!isCofflocation_1Empty && !isCofflocation_2Empty)
        {
            items.espresso_soft.SetActive(true);
            return;
        }

        if (isCofflocation_1Empty)
        {
           
            Espresso =  Instantiate(Coffeprefab, CoffeespawnLocation_1.transform.position, Quaternion.AngleAxis(90, Vector3.left));
            isCofflocation_1Empty = false;
            setMealArr(esp);
            
        }

        else if (isCofflocation_2Empty)
        {
            Espresso2 = Instantiate(Coffeprefab, CoffeespawnLocation_2.transform.position, Quaternion.AngleAxis(90, Vector3.left));
            
            isCofflocation_2Empty = false;
            
            setMealArr(esp);
            
        }

    }

    public void LatteCoffeeSpawn()
    {
        string latte = "Latte";
        
        if (!isCofflocation_1Empty && !isCofflocation_2Empty)
        {
            items.latte.SetActive(true);
            return;
        }

        if (isCofflocation_1Empty)
        {
            Latte = Instantiate(Coffeprefab, CoffeespawnLocation_1.transform.position, Quaternion.AngleAxis(90, Vector3.left));
            
            isCofflocation_1Empty = false;
            
            setMealArr(latte);
            
        }

        else if (isCofflocation_2Empty)
        {
            Latte2 = Instantiate(Coffeprefab, CoffeespawnLocation_2.transform.position, Quaternion.AngleAxis(90, Vector3.left));
            
            isCofflocation_2Empty = false;
            
            setMealArr(latte);
            
        }

    }

    public void IceLatteCoffeeSpawn()
    {
        string icelatte = "IceLatte";

        if (!isCofflocation_1Empty && !isCofflocation_2Empty)
        {
            items.icelatte.SetActive(true);
            return;
        }

        if (isCofflocation_1Empty)
        {
            IceLatte = Instantiate(IceCoffeprefab, CoffeespawnLocation_1.transform.position, Quaternion.AngleAxis(90, Vector3.left));
            
            isCofflocation_1Empty = false;
            
            setMealArr(icelatte);
            
        }

        else if (isCofflocation_2Empty)
        {
            IceLatte2 = Instantiate(IceCoffeprefab, CoffeespawnLocation_2.transform.position, Quaternion.AngleAxis(90, Vector3.left));
          
            isCofflocation_2Empty = false;
           
            setMealArr(icelatte);
            
        }

    }

    public void iceAmericanoCoffeeSpawn()
    {
        string iceAmericano = "IceAmericano";

        if (!isCofflocation_1Empty && !isCofflocation_2Empty)
        {
            items.iceAmericano.SetActive(true);
            return;
        }

        if (isCofflocation_1Empty)
        {
            IceAmericano = Instantiate(IceCoffeprefab, CoffeespawnLocation_1.transform.position, Quaternion.AngleAxis(90, Vector3.left));
            
            isCofflocation_1Empty = false;
            
            setMealArr(iceAmericano);
            
        }

        else if (isCofflocation_2Empty)
        {
            IceAmericano2 = Instantiate(IceCoffeprefab, CoffeespawnLocation_2.transform.position, Quaternion.AngleAxis(90, Vector3.left));
            
            isCofflocation_2Empty = false;
            
            setMealArr(iceAmericano);
            
        }

    }

    public void AmericanoCoffeeSpawn()
    {
        string americano = "Americano";

        if (!isCofflocation_1Empty && !isCofflocation_2Empty)
        {
            items.americano.SetActive(true);
            return;
        }

        if (isCofflocation_1Empty)
        {
            Americano= Instantiate(Coffeprefab, CoffeespawnLocation_1.transform.position, Quaternion.AngleAxis(90, Vector3.left));
           
            isCofflocation_1Empty = false;
            
            setMealArr(americano);
            
        }

        else if (isCofflocation_2Empty)
        {
            Americano2 = Instantiate(Coffeprefab, CoffeespawnLocation_2.transform.position, Quaternion.AngleAxis(90, Vector3.left));
           
            isCofflocation_2Empty = false;
           
            setMealArr(americano);
           
        }


    }

    public void Milk_filterCoffeeSpawn()
    {
        string filtermilk = "FilterMilk";

        if (!isCofflocation_1Empty && !isCofflocation_2Empty)
        {
            items.milk_filter.SetActive(true);
            return;
        }

        if (isCofflocation_1Empty)
        {
            FilterMilk= Instantiate(Coffeprefab, CoffeespawnLocation_1.transform.position, Quaternion.AngleAxis(90, Vector3.left));
            
            isCofflocation_1Empty = false;
           
            setMealArr(filtermilk);
            
        }

        else if (isCofflocation_2Empty)
        {
            FilterMilk2 = Instantiate(Coffeprefab, CoffeespawnLocation_2.transform.position, Quaternion.AngleAxis(90, Vector3.left));
            
            isCofflocation_2Empty = false;
          
            setMealArr(filtermilk);
            
        }

    }


    public void Soft_filterCoffeeSpawn()
    {
        string filter = "Filter";

        if (!isCofflocation_1Empty && !isCofflocation_2Empty)
        {
            items.soft_filter.SetActive(true);
            return;
        }

        if (isCofflocation_1Empty)
        {
            Filter = Instantiate(Coffeprefab, CoffeespawnLocation_1.transform.position, Quaternion.AngleAxis(90, Vector3.left));
            
            isCofflocation_1Empty = false;
            
            setMealArr(filter);
            
        }

        else if (isCofflocation_2Empty)
        {
            Filter2 = Instantiate(Coffeprefab, CoffeespawnLocation_2.transform.position, Quaternion.AngleAxis(90, Vector3.left));
            
            isCofflocation_2Empty = false;
            
            setMealArr(filter);
           
        }



    }


    //-----------Deserts Spawner-------------

    public void DonutSpawn()
    {
        string donut = "Donut";
        if (!islocation_1Empty && !islocation_2Empty)
        {
            items.donut.SetActive(true);
            return;
        }

        if (islocation_1Empty)
        {
            DesertspawnLocation_1.transform.position = donut_Loc1.transform.position;
           Donut = Instantiate(Donutfab, DesertspawnLocation_1.transform.position, Quaternion.AngleAxis(90, Vector3.left));
           
            islocation_1Empty = false;
            
            setMealArr(donut);
            
        }
        else if (islocation_2Empty)
        {
            DesertspawnLocation_2.transform.position = donut_Loc2.transform.position;
            Donut2 = Instantiate(Donutfab, DesertspawnLocation_2.transform.position, Quaternion.AngleAxis(90, Vector3.left));
           
            islocation_2Empty = false;
            
            setMealArr(donut);
            
        }

    }

    public void CupCakeSpawn()
    {
        string cupcake = "CupCake";

        if (!islocation_1Empty && !islocation_2Empty)
        {
            items.cupcake.SetActive(true);
            return;
        }

        if (islocation_1Empty)
        {
            DesertspawnLocation_1.transform.position = cupcake_Loc1.transform.position;
            CupCake = Instantiate(CupCakeprefab, DesertspawnLocation_1.transform.position, Quaternion.AngleAxis(90, Vector3.left));

            islocation_1Empty = false;
           
            setMealArr(cupcake);
            
        }
        else if (islocation_2Empty)
        {
            DesertspawnLocation_2.transform.position = cupcake_Loc2.transform.position;
            CupCake2 = Instantiate(CupCakeprefab, DesertspawnLocation_2.transform.position, Quaternion.AngleAxis(90, Vector3.left));
            
            islocation_2Empty = false;

           
            setMealArr(cupcake);
           
        }

    }

    public void CarrotCakeSpawn()
    {
        string cake = "CarrotCake";
        
        if (!islocation_1Empty && !islocation_2Empty)
        {
            items.cake.SetActive(true);
            return;
        }

        if (islocation_1Empty)
        {
            
            DesertspawnLocation_1.transform.position = cake_Loc1.transform.position;
            CarrotCake = Instantiate(CarrotCakeprefab, DesertspawnLocation_1.transform.position, Quaternion.AngleAxis(90, Vector3.left));
            
            islocation_1Empty = false;
            setMealArr(cake);
            
        }
        else if (islocation_2Empty)
        {
            DesertspawnLocation_2.transform.position = cake_Loc2.transform.position;
            CarrotCake2 = Instantiate(CarrotCakeprefab, DesertspawnLocation_2.transform.position, Quaternion.AngleAxis(90, Vector3.left));
            
            islocation_2Empty = false;
            
            setMealArr(cake);
            
        }
       


    }


    public void setMealArr(string meal)
    {
    
        Meals[i] = meal;
        i++;
        c++;
        if(Meals[i]!="")
		{
            setArr(Meals);

        }
        
    }

    public void setArr(string[]meals)
    {
        CompareOrderManager compare = FindObjectOfType<CompareOrderManager>();
        compare.SetingMeals(meals);
        
    }

    public void ResetMeal()
	{
       
            Meals = null;

        
    }


    public void ResetMeals()
	{
        
          islocation_1Empty = true;
          islocation_2Empty = true;
          isCofflocation_1Empty = true;
          isCofflocation_2Empty = true;
        i = 0;
        c = 1;
            Destroy(Espresso);
            Destroy(FilterMilk);
            Destroy(Filter);
            Destroy(IceLatte);
            Destroy(IceAmericano);
            Destroy(Americano);
            Destroy(Latte);
            Destroy(Donut);
            Destroy(CupCake);
            Destroy(CarrotCake);

            Destroy(Espresso2);
            Destroy(FilterMilk2);
            Destroy(Filter2);
            Destroy(IceLatte2);
            Destroy(IceAmericano2);
            Destroy(Americano2);
            Destroy(Latte2);
            Destroy(Donut2);
            Destroy(CupCake2);
            Destroy(CarrotCake2);
        
      
    }
}  
