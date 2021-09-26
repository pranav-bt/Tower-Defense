using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    [SerializeField] GameObject weapon, hand;
    [SerializeField] float attackspeed = 1f;
    bool isfire;
    Animator animator;
    Attackerspawn setmylane;
    private void Start()
    {
        checklane();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (checkedlane())
        {
            animator.SetBool("isattack", true);
        }
        else
        {
            animator.SetBool("isattack", false);
        }
    }

    private bool checkedlane()
    {
        if (setmylane.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void checklane()
    {
        Attackerspawn[] attackers = FindObjectsOfType<Attackerspawn>();
        foreach (Attackerspawn attackerr in attackers)
        { 
            bool isclose = (Math.Abs(attackerr.transform.position.y - transform.position.y) <= 0.1);
            {
                if(isclose)
                {
                    setmylane = attackerr;
                }
            }
        }

    }

 /*   public void shootcondition(bool shoot)
    {
        animator = GetComponent<Animator>();
        if(shoot==true)
        {
            animator.SetBool("isattack", true);
        }
        if (shoot == false)
        {
            animator.SetBool("isattack", false);
        }
    }*/

    public void shoot(float value)
    {
      Instantiate(weapon, hand.transform.position, Quaternion.Euler(0, 0, 270));
      
    }

}
