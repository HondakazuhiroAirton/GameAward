using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseManager : MonoBehaviour
{
    // フェーズアニメーション
    Animator animator;

    // UI
    public GameObject phase1;
    public GameObject phase2;
    public GameObject phase3;
    public GameObject phase4;
    public GameObject phase5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayPhase(int no)
    {
        // フェーズの再生
        // 呼び出された番号で分岐する
        switch (no)
        {
            case 1:
                animator = phase1.GetComponent<Animator>();
                break;
            case 2:
                animator = phase2.GetComponent<Animator>();
                break;
            case 3:
                animator = phase3.GetComponent<Animator>();
                break;
            case 4:
                animator = phase4.GetComponent<Animator>();
                break;
            case 5:
                animator = phase5.GetComponent<Animator>();
                break;
            default:
                return;
        }
        animator.SetTrigger("PhaseTrigger");
    }
}
