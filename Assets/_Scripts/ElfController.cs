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
    }

    public void SetRoute()
    {
        transform.Rotate(0, 180, 0);
        animator.SetBool("IsFlying", true);
    }

    public void Pause()
    {

    }

    public void Resume()
    {

    }
}