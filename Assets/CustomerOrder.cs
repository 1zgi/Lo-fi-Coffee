using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CustomerAI;
using static CompareOrderManager;

public class CustomerOrder : MonoBehaviour
{
    bool isOrdered  = false;
    public CustomerAI customerAI;
    public CompareOrderManager manager;


    [Header("COFFEE MATERIALS")]
    [SerializeField] private Material filterMilkMaterial;
    [SerializeField] private Material filterMaterial;
    [SerializeField] private Material espressoMaterial;
    [SerializeField] private Material latteMaterial;
    [SerializeField] private Material americanoMaterial;
    [SerializeField] private Material iceLatteMaterial;
    [SerializeField] private Material iceAmericanoMaterial;
    [Header("DESERT  MATERIALS")]
    [SerializeField] private Material donutMaterial;
    [SerializeField] private Material cupcakeMaterial;
    [SerializeField] private Material carrotcakeMaterial;

    [SerializeField] private Material originalMaterial;

    [Header("The  Menu")]
    public string[] coffeeArr = new string[8];
    public int publichowMuchRandomCoff;
    public string[] DesertArr = new string[4];
    public int publichowMuchRandomDES;

    [Header("Order Signs")]
    public GameObject FirstCoffeOrder_Sign;
    public GameObject SecondCoffeOrder_Sign;
    public GameObject FirstDesertOrder_Sign;
    public GameObject SecondDesertOrder_Sign;

    public int[] randomCoff;
    public int[] randomDES;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PickRandomCoffeOrder(int howMuchRandomCoff , int howMuchRandomDES)
	{
        int count=0;
        int countD = 0;

        if (howMuchRandomCoff == 0 && howMuchRandomDES == 0)
            GetRandom();
        

        if(howMuchRandomCoff==0 && howMuchRandomDES == 0)
		{
            return;
		}

        if (howMuchRandomCoff != 0)
		{
            randomCoff = new int[howMuchRandomCoff];
            for (int i = 0; i < howMuchRandomCoff; i++)
            {
                randomCoff[i] = Random.Range(0, coffeeArr.Length);
                print("randomCoff: " + randomCoff[i]);
            }
        }

        if (howMuchRandomDES!=0)
		{
            randomDES = new int[howMuchRandomDES];
            for (int i = 0; i < howMuchRandomDES; i++)
            {
                randomDES[i] = Random.Range(0, DesertArr.Length);
                print("randomDES: " + randomDES[i]);
            }
        }
        
        printOrder(howMuchRandomCoff,howMuchRandomDES);

    }

    public void printOrder(int cof,int des)
	{
        var firstcoffsign = FirstCoffeOrder_Sign.GetComponent<MeshRenderer>();
        var secondcoffsign = SecondCoffeOrder_Sign.GetComponent<MeshRenderer>();
        var firstDESsign = FirstDesertOrder_Sign.GetComponent<MeshRenderer>();
        var secondDESsign = SecondDesertOrder_Sign.GetComponent<MeshRenderer>();

        //Setting defalut material when  clicke  again and again
        firstcoffsign.material = originalMaterial;
        secondcoffsign.material = originalMaterial;
        firstDESsign.material = originalMaterial;
        secondDESsign.material = originalMaterial;

        //check slot  is empty or  not
        bool isCoffordersign_1Empty = true;
        bool isCoffordersign_2Empty = true;

        bool isDESordersign_1Empty = true;
        bool isDESordersign_2Empty = true;


        int length= randomCoff.Length + randomDES.Length ;
        string[] fullorder = new string[length];

        //puting all order to the new array
        if(cof!=0)
		{
            for (int i = 0; i < randomCoff.Length; i++)
            {

                fullorder[i] = coffeeArr[randomCoff[i]];

            }
        }
        
        if(des!=0)
		{
            for (int j = 0; j < randomDES.Length; j++)
            {
                fullorder[randomCoff.Length + j] = DesertArr[randomDES[j]];
            }
        }

        for (int i = 0; i < length; i++)
        {

                printFull(fullorder ,i);

        }

     
        //setting active order images 
        for (int i = 0; i < length; i++)
		{
            switch (fullorder[i])
            {
            case "FilterMilk":
                if (isCoffordersign_1Empty)
                {
                    firstcoffsign.material = filterMilkMaterial;
                    isCoffordersign_1Empty = false;
                }
                else
                {
                    secondcoffsign.material = filterMilkMaterial;

                }
                    Reset();
                break;

            case "Filter":
                if (isCoffordersign_1Empty)
                {
                    firstcoffsign.material = filterMaterial;
                    isCoffordersign_1Empty = false;
                }
                else
                {
                    secondcoffsign.material = filterMaterial;
                }
                Reset();
                break;

            case "Espresso":
                if (isCoffordersign_1Empty)
                {
                    firstcoffsign.material = espressoMaterial;
                    isCoffordersign_1Empty = false;
                }
                else
                {
                    secondcoffsign.material = espressoMaterial;
                }
                Reset();
                break;

            case "Latte":
                if (isCoffordersign_1Empty)
                {
                    firstcoffsign.material = latteMaterial;
                    isCoffordersign_1Empty = false;
                }
                else
                {
                    secondcoffsign.material = latteMaterial;
                }
                Reset();
                break;

            case "IceLatte":
                if (isCoffordersign_1Empty)
                {
                    firstcoffsign.material = iceLatteMaterial;
                    isCoffordersign_1Empty = false;
                }
                else
                {
                    secondcoffsign.material = iceLatteMaterial;
                }
                Reset();
                break;

            case "IceAmericano":
                if (isCoffordersign_1Empty)
                {
                    firstcoffsign.material = iceAmericanoMaterial;
                    isCoffordersign_1Empty = false;
                }
                else
                {
                    secondcoffsign.material = iceAmericanoMaterial;
                }
                Reset();
                break;

            case "Americano":
                if (isCoffordersign_1Empty)
                {
                    firstcoffsign.material = americanoMaterial;
                    isCoffordersign_1Empty = false;
                }
                else
                {
                    secondcoffsign.material = americanoMaterial;
                }
                Reset();
                break;

            case "Donut":
                if (isDESordersign_1Empty)
                {
                    firstDESsign.material = donutMaterial;
                    isDESordersign_1Empty = false;
                }
                else
                {
                    secondDESsign.material = donutMaterial;
                }
                Reset();
                break;

            case "CupCake":
                if (isDESordersign_1Empty)
                {
                    firstDESsign.material = cupcakeMaterial;
                    isDESordersign_1Empty = false;
                }
                else
                {
                    secondDESsign.material = cupcakeMaterial;
                }
                Reset();
                break;

            case "CarrotCake":
                if (isDESordersign_1Empty)
                {
                    firstDESsign.material = carrotcakeMaterial;
                    isDESordersign_1Empty = false;
                }
                else
                {
                    secondDESsign.material = carrotcakeMaterial;
                }
                Reset();
                break;

              default:

                    if (isDESordersign_1Empty && (i == 2 || i == 3))
                    {
                        firstDESsign.material = originalMaterial;
                        isDESordersign_1Empty = false;
                    }
                    else if (!isDESordersign_1Empty && (i == 2 || i == 3))
                    {
                        secondDESsign.material = originalMaterial;
                    }

                    if (isCoffordersign_1Empty && (i == 0 || i == 1))
                    {
                        firstcoffsign.material = originalMaterial;
                        isCoffordersign_1Empty = false;
                    }

                    else if (!isDESordersign_1Empty && (i == 0 || i == 1))
                    {
                        secondcoffsign.material = originalMaterial;
                    }
                   
                    break;
            }


        }

        fullorder = null;
    }


    public void printFull(string[] fullOrder,int a)
	{
        print(fullOrder[a]);
        CompareOrderManager compare = FindObjectOfType<CompareOrderManager>();
        compare.SetingOrder(fullOrder);
        compare.PrintAll();

    }

    public void ResetMAT()
	{
        var firstcoffsign = FirstCoffeOrder_Sign.GetComponent<MeshRenderer>();
        var secondcoffsign = SecondCoffeOrder_Sign.GetComponent<MeshRenderer>();
        var firstDESsign = FirstDesertOrder_Sign.GetComponent<MeshRenderer>();
        var secondDESsign = SecondDesertOrder_Sign.GetComponent<MeshRenderer>();

        firstcoffsign.material = originalMaterial;
        secondcoffsign.material = originalMaterial;
        firstDESsign.material = originalMaterial;
        secondDESsign.material = originalMaterial;
    }

    public void Reset()
	{
        publichowMuchRandomCoff = 0;
        publichowMuchRandomDES = 0;
      //randomCoff = null;
      //randomDES =  null;
    }
    

    public void  GetRandom()
	{
        isOrdered = true;
        IsOrderedd();
        int Cof = Random.Range(0, 3);
        int Des = Random.Range(0, 3);

        publichowMuchRandomCoff = Cof;//control randdom event while game is working
        publichowMuchRandomDES = Des;

        PickRandomCoffeOrder(Cof,Des);
	}

    
    public void IsOrderedd()
	{
        CustomerAI customerAI = FindObjectOfType<CustomerAI>();
        customerAI.checkOrdered(isOrdered);
        isOrdered = false;
       
    }
}
