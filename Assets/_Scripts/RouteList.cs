using System.Collections;
using System.Collections.Generic;
using Battlehub.SplineEditor;
using UnityEngine;
using _Scripts;

public class RouteList : MonoBehaviour
{
    public static RouteList instance;

    private List<Route> Routes = new List<Route>();
    private GameObject tianchiArrow;
    [SerializeField] private SplineBase tianchiRoute;
    [SerializeField] private Transform tianchiPos;


    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    private void Start()
    {
        CreateRoutineList();
    }

    private void OnDestroy()
    {
        if (instance)
        {
            instance = null;
        }
    }

    private void CreateRoutineList()
    {
        Route tianchi = new Route(tianchiRoute, tianchiArrow, "天池", 1000, 15, tianchiPos.position);
        Routes.Add(tianchi);
    }

    public Route GetRoute(SceneryName name)
    {
        return Routes[(int) name];
    }
}