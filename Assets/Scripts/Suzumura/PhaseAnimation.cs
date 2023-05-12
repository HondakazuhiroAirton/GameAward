using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseAnimation : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("IsStart", false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayPhase()
    {
        animator.SetBool("IsStart", true);
    }
}
