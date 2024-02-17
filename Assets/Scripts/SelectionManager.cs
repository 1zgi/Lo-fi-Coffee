using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using static CustomerOrder;
using static Player;
using static AnimatorPlayer;
using static CompareOrderManager;
using static CustomerAI;



public class SelectionManager : MonoBehaviour
{

    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material originalMaterial;
    [SerializeField] private GameObject Filter_Machine;
    [SerializeField] private GameObject Espresso_Machine;
    [SerializeField] private GameObject Ice_Machine;
    [SerializeField] private GameObject Desert_Fridge;
    [SerializeField] private GameObject Monitor;
    [SerializeField] private GameObject Recipe_Book;
    [SerializeField] public GameObject Tray;

    public AnimatorPlayer animator;

    
    public Player player;
    public FilterMachineUI filterMachine;
    public EspressoMachine espressoMachine;
    public CustomerOrder order;
    public BookUI bookui;
    public DesertFridgeUI fridgeUI;
    public TrayUI trayUI;

    public LayerMask selectionMask;
    public Camera playerCamera;
    public GameObject currentHitGameObject;
    string TagFilter;
    string TagEspresso;
    string TagIce;
    string TagFridge;
    string TagMonitor;
    string TagBook;
    string TagTray;

    bool count =false;

    private Transform _selection;
    bool clicked = false;
    bool checkWayPoint = false;

    void Start()
    {
        TagFilter = Filter_Machine.tag;
        TagEspresso = Espresso_Machine.tag;
        TagIce = Ice_Machine.tag;
        TagFridge = Desert_Fridge.tag;
        TagMonitor = Monitor.tag;
        TagBook = Recipe_Book.tag;
        TagTray = Tray.tag;
    }

    void Update()
    {
    
        if (_selection!=null)
		{
            var selectionRenderer = _selection.GetComponent<MeshRenderer>();
            selectionRenderer.material = originalMaterial;
            _selection = null;
        }

        var ray = playerCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

       

        if (Physics.Raycast(ray, out hit, 100, selectionMask) )
        {
            

            var selection = hit.transform;
            var selectionRenderer = selection.GetComponent<Renderer>();
            currentHitGameObject = hit.transform.gameObject;
            var getTag = currentHitGameObject.tag;

            originalMaterial = selectionRenderer.material; //We get the original material from mesh and applied for orginalMaterial. (holded)
            if(selectionRenderer !=null)
			{
                selectionRenderer.material= highlightMaterial;
            }

          
            if (Input.GetMouseButtonDown(0) && getTag == TagFilter)
            {
                _selection = selection;
                filterMachine.OpenFilterMachineWindow();
                player.ClosePlayerNav();
                clicked = true;
                player.AnimationAfterClicked(clicked);
                print(getTag);
            }
             if(Input.GetMouseButtonDown(0) && getTag == TagEspresso)
			{
                _selection = selection;
                espressoMachine.OpenEspressoMachineWindow();
                player.ClosePlayerNav();
                clicked = true;
                player.AnimationAfterClicked(clicked);
               
                print(getTag);
                
            }
             if (Input.GetMouseButtonDown(0) && getTag == TagIce)
            {
                
                _selection = selection;
                clicked = true;
                player.AnimationAfterClicked(clicked);
                
                print(getTag);
                
            }
             if (Input.GetMouseButtonDown(0) && getTag == TagMonitor)
             {
                _selection = selection;
                clicked = true;
                print(getTag);
               
            }
             if (Input.GetMouseButtonDown(0) && getTag == TagFridge)
            {
               
                _selection = selection;
                fridgeUI.OpenFridgeMachineWindow();
                player.ClosePlayerNav();
                clicked = true;
                player.AnimationAfterClicked(clicked);
                
                print(getTag);
               
            }
            if (Input.GetMouseButtonDown(0) && getTag == TagBook)
            {
                _selection = selection;
                bookui.OpenBookMachineWindow();
                player.ClosePlayerNav();
                clicked = true;
                player.AnimationAfterClicked(clicked);
                
                print(getTag);
                
            }
            if (Input.GetMouseButtonDown(0) && getTag == TagTray)
            {
                _selection = selection;
                trayUI.OpenTrayWindow();
                player.ClosePlayerNav();
                clicked = true;
                player.AnimationAfterClicked(clicked); 
                print(getTag);
                
            }

            _selection = selection;
        }

    
    }




   
}
