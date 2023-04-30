using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animasyon : MonoBehaviour
{
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Update()
    {
       if (KucukCubuk.oyunbitti == true)
        {
            animator.SetBool("OyunBitti", true);
        }
    }
}
