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
    public static ElfController instance;

    private Animator animator;
    private SplineFollow splineFollow;

    private void Awake()
    {
        instance = this;
    }

    private void OnDestroy()
    {
        instance = null;
    }

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

    public void Pause()
    {
        splineFollow.Speed = 0;
    }

    public void Resume()
    {
        splineFollow.Speed = 1;
    }
}