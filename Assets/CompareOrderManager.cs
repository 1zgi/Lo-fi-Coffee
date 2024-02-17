using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Spawner;
using static ScoreManager;

public class CompareOrderManager : MonoBehaviour
{
    string[] meals = new string[4];
    string[] order = new string[4];
    int a = 0;
    bool checkmeal = false;
    bool checkorder = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  void SetingOrder(string[] Order)
	{
        checkorder = true;
        order = new string[Order.Length];
        for (int i=0;i<Order.Length;i++)
		{
            order[i] = Order[i];
		}
        
    }

    public void SetingMeals(string[] Meal)
    {
        checkmeal = true;
        meals = new string[Meal.Length];
        
        for (int i = 0; i < Meal.Length; i++)
        {
            if (Meal[i]!="")
                meals[i] = Meal[i];
        }

        
    }

    public void PrintAll()
	{
        if(checkorder)
		{
            print("inorder");
            for (int i = 0; i < order.Length; i++)
            {
                print("Order:" + order[i]);
            }
        }
        
        if(checkmeal)
		{
            for (int i = 0; i < meals.Length; i++)
            {
                print("Meal:" + meals[i]);
            }
        }
        
    }


    public void Compare()
	{
        PrintAll();
        int totalOrderMoney=0;

        print("compare");
        for (int i = 0;i< order.Length;i++)
		{
            for(int  j  = 0;j<meals.Length;j++)
			{
                if(order[i]==meals[j])
				{
                    print(order[i]);
                    if(order[i] == "Americano")
					{
                        totalOrderMoney = 3;
                        sendMoney(totalOrderMoney);

                    }

                    if (order[i] == "IceAmericano")
                    {
                        totalOrderMoney = 3;
                        sendMoney(totalOrderMoney);
                    }

                     if (order[i] == "IcLatte")
                    {
                        totalOrderMoney = 4;
                        sendMoney(totalOrderMoney);
                    }
                     if (order[i] == "Latte")
                    {
                        totalOrderMoney = 4;
                       sendMoney(totalOrderMoney);
                    }

                     if (order[i] == "Espresso")
                    {
                        totalOrderMoney = 2;
                        sendMoney(totalOrderMoney);
                    }

                     if (order[i] == "Filter")
                    {
                        totalOrderMoney = 2;
                         sendMoney(totalOrderMoney);
                    }

                     if (order[i] == "FilterMilk")
                    {
                        totalOrderMoney = 3;
                        sendMoney(totalOrderMoney);
                    }

                     if (order[i] == "Donut")
                    {
                        totalOrderMoney = 3;
                         sendMoney(totalOrderMoney);
                    }

                     if (order[i] == "CupCake")
                    {
                        totalOrderMoney = 3;
                         sendMoney(totalOrderMoney);
                    }

                     if (order[i] == "CarrotCake")
                    {
                        totalOrderMoney = 4;
                        sendMoney(totalOrderMoney);
                    }
                    else
					{
                        totalOrderMoney = 0;
                         sendMoney(totalOrderMoney);
                        //totalOrderMoney += 0;
                    }
                    
                }
			}
		}
        
    }


    public int sendMoney(int totalorder)
	{

        ScoreManager score = FindObjectOfType<ScoreManager>();
        score.AddScore(totalorder);
        totalorder = 0;
        return totalorder;

    }


}
