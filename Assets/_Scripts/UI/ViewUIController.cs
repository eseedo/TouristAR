using System;
using System.Collections;
using System.Collections.Generic;
using HedgehogTeam.EasyTouch;
using UnityEngine;

public class ViewUIController : MonoBehaviour
{
    [Tooltip("缩放的灵敏度")] [Range(0.1f, 1.5f)] public float Factor;

    private void OnEnable()
    {
        EasyTouch.On_PinchIn += OnPinchIn;
        EasyTouch.On_PinchOut += OnPinchOut;
    }

    private void OnPinchOut(Gesture gesture)
    {
        float zoom = Time.deltaTime * gesture.deltaPinch * Factor;

        Vector3 scale = GetComponent<RectTransform>().localScale;
        GetComponent<RectTransform>().localScale = new Vector3(scale.x + zoom, scale.y + zoom, scale.z - zoom);
    }

    private void OnPinchIn(Gesture gesture)
    {
        float zoom = Time.deltaTime * gesture.deltaPinch * Factor;

        Vector3 scale = GetComponent<RectTransform>().localScale;
        if (scale.x <= 0.1)
        {
            return;
        }
        GetComponent<RectTransform>().localScale = new Vector3(scale.x - zoom, scale.y - zoom, scale.z - zoom);
    }
}