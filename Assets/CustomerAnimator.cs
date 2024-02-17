using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerAnimator : MonoBehaviour
{
    private Animator animatorCustomer;
    // Start is called before the first frame update
    void Start()
    {
        animatorCustomer = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoingSomething()
    {
       // animator.SetBool("ClickedStaff", true);
    }
    public void CloseDoingSomething()
    {
        //animator.SetBool("ClickedStaff", false);
    }
    public void SetAnimFalse()
    {
        animatorCustomer.SetBool("IsWalking", true);
    }

    public void SetAnimTrue()
    {
       animatorCustomer.SetBool("IsWalking", false);
    }

}
