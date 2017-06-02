using System;
using System.Collections;
using System.Collections.Generic;
using Battlehub.SplineEditor;
using UnityEngine;

/// <summary>
/// 控制小精灵行为的脚本
/// </summary>
public class ElfController : MonoBehaviour
{
    public event Action OnRouteFinished;

    private Animator animator;
    private SplineFollow splineFollow;

    void Start()
    {
        animator = GetComponent<Animator>();
        splineFollow = GetComponent<SplineFollow>();
    }

    public void SetRoute(SplineBase spline)
    {
        if (splineFollow.enabled == false)
        {
            splineFollow.enabled = true;
        }
        splineFollow.Spline = spline;
        animator.SetBool("IsFlying", true);
    }
}