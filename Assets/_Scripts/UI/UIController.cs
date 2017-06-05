﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public enum Canvas
    {
        ScanUI = 0,
        WelcomeUI,
        SelectUI,
        GuideUI,
        PhotoUI,
    }

    public CanvasGroup ScanUI;
    public CanvasGroup GuideUI;
    public CanvasGroup PhotoUI;
    public CanvasGroup SelectUI;
    public CanvasGroup WelcomeUI;

    private List<CanvasGroup> canvasGroups = new List<CanvasGroup>();

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    private void OnDestroy()
    {
        if (instance)
        {
            instance = null;
        }
    }


    private void Start()
    {
        canvasGroups.Add(ScanUI);
        canvasGroups.Add(WelcomeUI);
        canvasGroups.Add(SelectUI);
        canvasGroups.Add(GuideUI);
        canvasGroups.Add(PhotoUI);
        ShowExcept(Canvas.ScanUI);
    }

    public void ShowExcept(Canvas canvas)
    {
        for (int i = 0; i < canvasGroups.Count; i++)
        {
            if (i == (int) canvas)
            {
                canvasGroups[i].alpha = 1;
                canvasGroups[i].gameObject.SetActive(true);
                continue;
            }

            canvasGroups[i].alpha = 0;
            canvasGroups[i].gameObject.SetActive(false);

        } 
    }
    
    public void HideScanUI()
    {
        ScanUI.alpha = 0;
        ScanUI.gameObject.SetActive(false);
    }

    public void ShowScanUI()
    {
        ScanUI.alpha = 1;
        ScanUI.gameObject.SetActive(true);

    }
    

    public void HideGuideUI()
    {
        GuideUI.alpha = 0;
        GuideUI.gameObject.SetActive(false);

    }

    public void ShowGuideUI()
    {
        GuideUI.alpha = 1;
        GuideUI.gameObject.SetActive(true);

    }

    public void HidePhotoUI()
    {
        PhotoUI.alpha = 0;
        PhotoUI.gameObject.SetActive(false);
        
        ElfController.instance.Resume();


    }
    
    public void ShowPhotoUI()
    {
        PhotoUI.alpha = 1;
        PhotoUI.gameObject.SetActive(true);
        
        ElfController.instance.Pause();

    }
    
    public void HideSelectUI()
    {
        SelectUI.alpha = 0;
        SelectUI.gameObject.SetActive(false);

    }
    
    public void ShowSelectUI()
    {
        SelectUI.alpha = 1;
        SelectUI.gameObject.SetActive(true);
        ShowExcept(Canvas.SelectUI);

    }
    
    public void HideWelcomeUI()
    {
        WelcomeUI.alpha = 0;
        ShowExcept(Canvas.SelectUI);
        
    }
    
    public void ShowWelcomeUI()
    {
        WelcomeUI.alpha = 1;
        WelcomeUI.gameObject.SetActive(true);

    }
}