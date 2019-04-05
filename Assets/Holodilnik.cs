using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holodilnik : MonoBehaviour
{
    public Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void playAnim()
    {
        animator.Play("hololnik");
    }
}
