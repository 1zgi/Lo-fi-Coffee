using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorPlayer : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoingSomething()
	{
        animator.SetBool("ClickedStaff", true);
	}
    public void CloseDoingSomething()
    {
        animator.SetBool("ClickedStaff", false);
    }
    public void SetAnimFalse()
	{
        animator.SetBool("IsMoving", false);
    }

    public void SetAnimTrue()
    {
        animator.SetBool("IsMoving", true);
    }

}
