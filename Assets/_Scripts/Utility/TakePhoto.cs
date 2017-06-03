using System;
using UnityEngine;
using System.Collections;
using System.IO;

public class TakePhoto : MonoBehaviour 
{
    public void Take()
    {
        Application.CaptureScreenshot("image.jpg");
    }
}