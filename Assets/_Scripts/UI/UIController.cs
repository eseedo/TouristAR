using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController instance;

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
        canvasGroups.Add(WelcomeUI);
        canvasGroups.Add(SelectUI);
        canvasGroups.Add(GuideUI);
        canvasGroups.Add(PhotoUI);
    }

    private void HideExcept(CanvasGroup canvas)
    {
        int index = canvasGroups.IndexOf(canvas);

        for (int i = 0; i < canvasGroups.Count; i++)
        {
            if (i == index)
            {
                continue;
            }

            canvasGroups[i].alpha = 0;
        }
    }

    public void HideGuideUI()
    {
        GuideUI.alpha = 0;
    }

    public void ShowGuideUI()
    {
        GuideUI.alpha = 1;
    }

    public void HidePhotoUI()
    {
        PhotoUI.alpha = 0;
    }
    
    public void ShowPhotoUI()
    {
        PhotoUI.alpha = 1;
    }
    
    public void HideSelectUI()
    {
        SelectUI.alpha = 0;
    }
    
    public void ShowSelectUI()
    {
        SelectUI.alpha = 1;
    }
    
    public void HideWelcomeUI()
    {
        WelcomeUI.alpha = 0;
    }
    
    public void ShowWelcomeUI()
    {
        WelcomeUI.alpha = 1;
    }
}