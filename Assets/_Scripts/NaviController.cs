using System.Collections;
using System.Collections.Generic;
using Battlehub.SplineEditor;
using UnityEngine;
using _Scripts;

public class NaviController : MonoBehaviour
{
    private ElfController elf;
    private float timer;
    private Route route;
    private float distance;
    [SerializeField] private Transform camera;

    private Coroutine timerRoutine;
    private Coroutine distanceRoutine;

    public float Timer
    {
        get { return timer; }
        set
        {
            timer = value;
            //更新UI
            Debug.Log("Time: " + timer);
        }
    }

    public float Distance
    {
        get { return distance; }
        set
        {
            distance = value;
            //更新UI
            Debug.Log("Distance: " + distance);
        }
    }

    private void Start()
    {
        elf = FindObjectOfType<ElfController>();
        if (elf == null)
        {
            Debug.LogError("无法找到ElfController");
        }
        
        //TODO 测试Route
        route = RouteList.instance.GetRoute(SceneryName.Tianchi);
    }

    public void StartNavi()
    {
        ClearData();
        if (route.Equals(null))
        {
            Debug.LogError("未指定路线");
            return;
        }

        elf.SetRoute(route.Spline);
        
        //隐藏和显示相关UI
        UIController.instance.ShowExcept(UIController.Canvas.GuideUI);
    }

    private void ClearData()
    {
        StopTimer();
        StopUpdateDistance();
    }

    private void StartTimer()
    {
        timerRoutine = StartCoroutine(CoStartTimer());
    }

    private IEnumerator CoStartTimer()
    {
        while (true)
        {
            Timer += .1f;

            yield return new WaitForSecondsRealtime(.1f);
        }
    }

    private void StopTimer()
    {
        if (timerRoutine != null)
        {
            StopCoroutine(timerRoutine);
            timerRoutine = null;
        }
        Timer = 0;
    }

    private void StartUpdateDistance()
    {
        distanceRoutine = StartCoroutine(UpdateDistance());
    }

    private void StopUpdateDistance()
    {
        if (distanceRoutine != null)
        {
            StopCoroutine(distanceRoutine);
            timerRoutine = null;
        }

        Distance = 0;
    }

    private IEnumerator UpdateDistance()
    {
        while (true)
        {
            CalculateDistance();
            yield return new WaitForSecondsRealtime(5f);
        }
    }

    /// <summary>
    /// 利用AR Camera 计算和目标点的直线距离
    /// </summary>
    private void CalculateDistance()
    {
        Distance = Vector3.Distance(camera.position, route.DestPos);
    }

    public void SetRoute(SceneryName name)
    {
        route = RouteList.instance.GetRoute(name);
    }
}